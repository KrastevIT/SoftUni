namespace MusicHub.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using MusicHub.Data.Models;
    using MusicHub.Data.Models.Enums;
    using MusicHub.DataProcessor.ImportDtos;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data";

        private const string SuccessfullyImportedWriter
            = "Imported {0}";
        private const string SuccessfullyImportedProducerWithPhone
            = "Imported {0} with phone: {1} produces {2} albums";
        private const string SuccessfullyImportedProducerWithNoPhone
            = "Imported {0} with no phone number produces {1} albums";
        private const string SuccessfullyImportedSong
            = "Imported {0} ({1} genre) with duration {2}";
        private const string SuccessfullyImportedPerformer
            = "Imported {0} ({1} songs)";

        public static string ImportWriters(MusicHubDbContext context, string jsonString)
        {
            var writerDtos = JsonConvert.DeserializeObject<ImportWriterDto[]>(jsonString);

            var writers = new List<Writer>();
            var sb = new StringBuilder();

            foreach (var dto in writerDtos)
            {

                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var writer = new Writer
                {
                    Name = dto.Name,
                    Pseudonym = dto.Pseudonym
                };


                writers.Add(writer);

                sb.AppendLine(string.Format(
                    SuccessfullyImportedWriter,
                    writer.Name));
            }

            context.Writers.AddRange(writers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportProducersAlbums(MusicHubDbContext context, string jsonString)
        {
            var producerDtos = JsonConvert.DeserializeObject<ImportProducer[]>(jsonString);

            var sb = new StringBuilder();
            var producers = new List<Producer>();

            foreach (var dto in producerDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var producer = new Producer
                {
                    Name = dto.Name,
                    Pseudonym = dto.Pseudonym,
                    PhoneNumber = dto.PhoneNumber,
                };

                bool isValidAlbum = true;

                foreach (var albumDto in dto.Albums)
                {
                    if (!IsValid(albumDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        isValidAlbum = false;
                        break;
                    }

                    var album = new Album
                    {
                        Name = albumDto.Name,
                        ReleaseDate = DateTime.ParseExact(albumDto.ReleaseDate, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture)
                    };

                    producer.Albums.Add(album);
                    continue;
                }

                if (isValidAlbum)
                {
                    producers.Add(producer);
                    if (producer.PhoneNumber == null)
                    {
                        sb.AppendLine(string.Format(SuccessfullyImportedProducerWithNoPhone,
                            producer.Name, producer.Albums.Count));
                    }
                    else
                    {
                        sb.AppendLine(string.Format(SuccessfullyImportedProducerWithPhone,
                            producer.Name, producer.PhoneNumber, producer.Albums.Count));
                    }
                }
            }

            context.Producers.AddRange(producers);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportSongs(MusicHubDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ImportSong[]),
                new XmlRootAttribute("Songs"));

            ImportSong[] songDtos;

            var sb = new StringBuilder();
            var songs = new List<Song>();

            using (var reader = new StringReader(xmlString))
            {
                songDtos = (ImportSong[])serializer.Deserialize(reader);
            }

            foreach (var dto in songDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var isValidEnum = Enum.TryParse<Genre>(dto.Genre,
                    out Genre genreType);

                if (isValidEnum == false)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var song = new Song
                {
                    Name = dto.Name,
                    Duration = TimeSpan.Parse(dto.Duration),
                    CreatedOn = DateTime.ParseExact(dto.CreatedOn, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture),
                    Genre = genreType,
                    AlbumId = dto.AlbumId,
                    WriterId = dto.WriterId,
                    Price = dto.Price
                };

                var album = context.Albums.FirstOrDefault(x => x.Id == song.AlbumId);
                var writer = context.Writers.FirstOrDefault(x => x.Id == song.WriterId);

                if (album == null || writer == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                songs.Add(song);
                sb.AppendLine(string.Format(SuccessfullyImportedSong, song.Name, song.Genre, song.Duration));
            }

            context.AddRange(songs);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportSongPerformers(MusicHubDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ImportSongPerformer[]),
                 new XmlRootAttribute("Performers"));

            ImportSongPerformer[] importSongPerformers;
            var sb = new StringBuilder();
            var performers = new List<Performer>();

            using (var reader = new StringReader(xmlString))
            {
                importSongPerformers = (ImportSongPerformer[])serializer.Deserialize(reader);
            }

            foreach (var dto in importSongPerformers)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var performer = new Performer
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Age = dto.Age,
                    NetWorth = dto.NetWorth
                };

                bool isValidSong = true;

                foreach (var songDto in dto.PerformerSongs)
                {
                    var song = context.Songs.FirstOrDefault(x => x.Id == songDto.Id);

                    if (song == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        isValidSong = false;
                        break;
                    }

                    var songPerformer = new SongPerformer
                    {
                        SongId = song.Id
                    };

                    performer.PerformerSongs.Add(songPerformer);
                }

                if (isValidSong)
                {
                    sb.AppendLine(string.Format(SuccessfullyImportedPerformer, performer.FirstName, performer.PerformerSongs.Count));
                    performers.Add(performer);
                    continue;
                }
            }

            context.Performers.AddRange(performers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object entity)
        {
            var validationContext = new ValidationContext(entity);
            var validationResult = new List<ValidationResult>();

            var result = Validator.TryValidateObject(entity, validationContext, validationResult, true);

            return result;
        }
    }
}