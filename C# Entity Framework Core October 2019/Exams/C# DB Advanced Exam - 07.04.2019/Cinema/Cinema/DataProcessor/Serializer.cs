namespace Cinema.DataProcessor
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Cinema.DataProcessor.ExportDto;
    using Data;
    using Newtonsoft.Json;

    public class Serializer
    {
        public static string ExportTopMovies(CinemaContext context, int rating)
        {
            var movies = context
                 .Movies
                 .Where(x => x.Rating >= rating && x.Projections.Any(p => p.Tickets.Count > 0))
                 .OrderByDescending(x => x.Rating)
                 .ThenByDescending(x => x.Projections.Sum(p => p.Tickets.Select(t => t.Price).Sum()))
                 .Select(m => new
                 {
                     MovieName = m.Title,
                     Rating = $"{m.Rating:F2}",
                     TotalIncomes = m.Projections.Sum(p => p.Tickets.Select(t => t.Price).Sum()).ToString("F2"),
                     Customers = m.Projections.SelectMany(p => p.Tickets.Select(t => new
                     {
                         FirstName = t.Customer.FirstName,
                         LastName = t.Customer.LastName,
                         Balance = $"{t.Customer.Balance:F2}"
                     }))
                     .OrderByDescending(x => x.Balance)
                     .ThenBy(x => x.FirstName)
                     .ThenBy(x => x.LastName)
                 })
                 .Take(10)
                 .ToList();

            var json = JsonConvert.SerializeObject(movies, Formatting.Indented);

            return json;
        }

        public static string ExportTopCustomers(CinemaContext context, int age)
        {
            var customers = context.Customers
                .Where(c => c.Age >= age)
                .OrderByDescending(c => c.Tickets.Sum(t => t.Price))
                .Select(c => new ExportCustomerDto
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    SpentMoney = $"{c.Tickets.Sum(t => t.Price):F2}",
                    SpentTime = TimeSpan
                        .FromSeconds(c.Tickets.Select(t => t.Projection).Sum(p => p.Movie.Duration.TotalSeconds))
                        .ToString(@"hh\:mm\:ss", CultureInfo.InvariantCulture)
                })
                .Take(10)
                .ToArray();

            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();

            using (var writer = new StringWriter())
            {
                var xmlSerializer = new XmlSerializer(typeof(ExportCustomerDto[]),
                    new XmlRootAttribute("Customers"));

                xmlSerializer.Serialize(writer, customers, ns);

                sb = writer.GetStringBuilder();
            }

            return sb.ToString().TrimEnd();
        }
    }
}