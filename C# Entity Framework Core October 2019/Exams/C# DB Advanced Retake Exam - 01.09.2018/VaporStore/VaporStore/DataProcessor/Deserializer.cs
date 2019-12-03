namespace VaporStore.DataProcessor
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
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.ImportDtos;

    public static class Deserializer
    {
        public static string ImportGames(VaporStoreDbContext context, string jsonString)
        {
            var gamesDto = JsonConvert.DeserializeObject<ImportGameDto[]>(jsonString);

            var sb = new StringBuilder();
            var games = new List<Game>();

            foreach (var gameDto in gamesDto)
            {
                if (!IsValid(gameDto) || gameDto.Tags.Count == 0)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var game = new Game
                {
                    Name = gameDto.Name,
                    Price = gameDto.Price,
                    ReleaseDate = DateTime
                        .ParseExact(gameDto.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)
                };

                var developer = GetDeveloper(context, gameDto.Developer);
                var genre = GetGenre(context, gameDto.Genre);

                game.Developer = developer;
                game.Genre = genre;

                foreach (var currentTag in gameDto.Tags)
                {
                    var tag = GetTag(context, currentTag);

                    game.GameTags.Add(new GameTag
                    {
                        Game = game,
                        Tag = tag
                    });
                }

                games.Add(game);
                sb.AppendLine($"Added {game.Name} ({game.Genre.Name}) with {game.GameTags.Count} tags");
            }

            context.Games.AddRange(games);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportUsers(VaporStoreDbContext context, string jsonString)
        {
            var usersDto = JsonConvert.DeserializeObject<ImportUserDto[]>(jsonString);

            var sb = new StringBuilder();
            var users = new List<User>();

            foreach (var dto in usersDto)
            {
                if (!IsValid(dto) || !dto.Cards.All(IsValid))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var user = new User
                {
                    FullName = dto.FullName,
                    Username = dto.Username,
                    Email = dto.Email,
                    Age = dto.Age
                };

                foreach (var cardDto in dto.Cards)
                {
                    user.Cards.Add(new Card
                    {
                        Number = cardDto.Number,
                        Cvc = cardDto.Cvc,
                        Type = cardDto.Type
                    });
                }

                users.Add(user);
                sb.AppendLine($"Imported {user.Username} with {user.Cards.Count} cards");
            }

            context.Users.AddRange(users);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ImportPurchaseDto[]),
                new XmlRootAttribute("Purchases"));

            var sb = new StringBuilder();
            ImportPurchaseDto[] purchaseDtos;
            var purchases = new List<Purchase>();

            using (var reader = new StringReader(xmlString))
            {
                purchaseDtos = (ImportPurchaseDto[])serializer.Deserialize(reader);
            }

            foreach (var dto in purchaseDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var game = context.Games.FirstOrDefault(x => x.Name == dto.Title);
                var card = context.Cards.FirstOrDefault(x => x.Number == dto.Card);

                if (game == null || card == null)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var isValidEnum = Enum.TryParse<PurchaseType>(dto.Type,
                    out PurchaseType purchaseType);

                var purchase = new Purchase
                {
                    Type = purchaseType,
                    Date = DateTime.ParseExact(dto.Date, "dd/MM/yyyy HH:mm",
                        CultureInfo.InvariantCulture),
                    ProductKey = dto.Key,
                    Game = game,
                    Card = card
                };

                purchases.Add(purchase);
                sb.AppendLine($"Imported {purchase.Game.Name} for {purchase.Card.User.Username}");
            }

            context.Purchases.AddRange(purchases);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object entity)
        {
            var validationContext = new ValidationContext(entity);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(entity, validationContext, validationResult, true);

            return isValid;
        }

        private static Developer GetDeveloper(VaporStoreDbContext context, string developerName)
        {
            var developer = context.Developers
                .FirstOrDefault(x => x.Name == developerName);

            if (developer == null)
            {
                developer = new Developer
                {
                    Name = developerName
                };

                context.Developers.Add(developer);
                context.SaveChanges();
            }

            return developer;
        }

        private static Genre GetGenre(VaporStoreDbContext context, string gameDtoGenre)
        {
            var genre = context.Genres.FirstOrDefault(x => x.Name == gameDtoGenre);

            if (genre == null)
            {
                genre = new Genre
                {
                    Name = gameDtoGenre
                };

                context.Genres.Add(genre);
                context.SaveChanges();
            }

            return genre;
        }

        private static Tag GetTag(VaporStoreDbContext context, string currentTag)
        {
            var tag = context.Tags.FirstOrDefault(x => x.Name == currentTag);

            if (tag == null)
            {
                tag = new Tag
                {
                    Name = currentTag
                };

                context.Tags.Add(tag);
                context.SaveChanges();
            }

            return tag;
        }
    }
}