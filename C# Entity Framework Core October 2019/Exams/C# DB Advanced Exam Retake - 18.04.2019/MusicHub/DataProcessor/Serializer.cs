namespace MusicHub.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using MusicHub.DataProcessor.ExportDtos;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albums = context
                .Albums
                .Where(x => x.ProducerId == producerId)
                .OrderByDescending(a => a.Songs.Sum(s => s.Price))

                .Select(a => new
                {
                    AlbumName = a.Name,
                    ReleaseDate = a.ReleaseDate.ToString("MM/dd/yyyy",
                    CultureInfo.InvariantCulture),
                    ProducerName = a.Producer.Name,
                    Songs = a.Songs
                             .Select(s => new
                             {
                                 SongName = s.Name,
                                 Price = $"{s.Price:F2}",
                                 Writer = s.Writer.Name
                             })
                             .OrderByDescending(s => s.SongName)
                             .ThenBy(s => s.Writer),
                    AlbumPrice = $"{a.Songs.Sum(x => x.Price):F2}"
                })
                .ToArray();

            var jsonResult = JsonConvert.SerializeObject(albums, Formatting.Indented);


            return jsonResult;
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {

            var time = TimeSpan.FromSeconds(duration);

            var songs = context
                .Songs
                .Where(s => s.Duration > time)
                .Select(s => new ExportSongDto
                {
                    SongName = s.Name,
                    Writer = s.Writer.Name,
                    Performer = s.SongPerformers.Select(sp => sp.Performer.FirstName + ' ' + sp.Performer.LastName).FirstOrDefault(),
                    AlbumProducer = s.Album.Producer.Name,
                    Duration = s.Duration.ToString("c", CultureInfo.InvariantCulture)
                })
                .OrderBy(s => s.SongName)
                .ThenBy(s => s.Writer)
                .ThenBy(s => s.Performer)
                .ToArray();


            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();

            using (var writer = new StringWriter())
            {
                var xmlSerializer = new XmlSerializer(typeof(ExportSongDto[]),
                    new XmlRootAttribute("Songs"));

                xmlSerializer.Serialize(writer, songs, ns);

                sb = writer.GetStringBuilder();
            }

            return sb.ToString().TrimEnd();

        }
    }
}