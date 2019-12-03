namespace VaporStore.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.DataProcessor.ExportDtos;

    public static class Serializer
    {
        public static string ExportGamesByGenres(VaporStoreDbContext context, string[] genreNames)
        {
            var genre = context
                .Genres
                .Where(g => genreNames.Contains(g.Name))
                .Select(g => new
                {
                    Id = g.Id,
                    Genre = g.Name,
                    Games = g.Games.Where(x => x.Purchases.Any())
                             .Select(ga => new
                             {
                                 Id = ga.Id,
                                 Title = ga.Name,
                                 Developer = ga.Developer.Name,
                                 Tags = string.Join(", ", ga.GameTags.Select(x => x.Tag.Name)),
                                 Players = ga.Purchases.Count()
                             })
                             .OrderByDescending(x => x.Players)
                             .ThenBy(x => x.Id)
                             .ToArray(),
                    TotalPlayers = g.Games.Sum(p => p.Purchases.Count)
                })
                .OrderByDescending(x => x.TotalPlayers)
                .ThenBy(x => x.Id)
                .ToList();

            var jsonResult = JsonConvert.SerializeObject(genre, Formatting.Indented);

            Console.WriteLine(jsonResult);

            return jsonResult;

        }

        public static string ExportUserPurchasesByType(VaporStoreDbContext context, string storeType)
        {
            var users = context.Users
                  .Select(u => new ExportUserDto
                  {
                      Username = u.Username,
                      Purchases = u.Cards
                          .SelectMany(c => c.Purchases)
                          .Where(p => p.Type.ToString() == storeType)
                          .Select(p => new ExportPurchaseDto
                          {
                              Card = p.Card.Number,
                              Cvc = p.Card.Cvc,
                              Date = p.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                              Game = new ExportGameDto
                              {
                                  Title = p.Game.Name,
                                  Genre = p.Game.Genre.Name,
                                  Price = p.Game.Price
                              }
                          })
                          .OrderBy(p => p.Date)
                          .ToArray(),
                      TotalSpent = u.Cards
                          .SelectMany(c => c.Purchases)
                          .Where(p => p.Type.ToString() == storeType)
                          .Sum(p => p.Game.Price)
                  })
                  .Where(u => u.Purchases.Any())
                  .OrderByDescending(u => u.TotalSpent)
                  .ThenBy(u => u.Username)
                  .ToArray();

            using var writer = new StringWriter();

            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            var serializer = new XmlSerializer(typeof(ExportUserDto[]), new XmlRootAttribute("Users"));
            serializer.Serialize(writer, users, ns);

            var usersXml = writer.GetStringBuilder();

            return usersXml.ToString().TrimEnd();
        }
    }
}