namespace Cinema.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Cinema.Data.Models;
    using Cinema.Data.Models.Enums;
    using Cinema.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";
        private const string SuccessfulImportMovie
            = "Successfully imported {0} with genre {1} and rating {2}!";
        private const string SuccessfulImportHallSeat
            = "Successfully imported {0}({1}) with {2} seats!";
        private const string SuccessfulImportProjection
            = "Successfully imported projection {0} on {1}!";
        private const string SuccessfulImportCustomerTicket
            = "Successfully imported customer {0} {1} with bought tickets: {2}!";

        public static string ImportMovies(CinemaContext context, string jsonString)
        {
            var movieDtos = JsonConvert.DeserializeObject<ImportMovieDto[]>(jsonString);

            var sb = new StringBuilder();
            var movies = new List<Movie>();

            foreach (var dto in movieDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var movie = new Movie
                {
                    Title = dto.Title,
                    Genre = dto.Genre,
                    Duration = dto.Duration,
                    Rating = dto.Rating,
                    Director = dto.Director
                };

                movies.Add(movie);
                sb.AppendLine(string.Format(SuccessfulImportMovie, movie.Title, movie.Genre, $"{movie.Rating:F2}"));
            }

            context.AddRange(movies);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportHallSeats(CinemaContext context, string jsonString)
        {
            var hallDtos = JsonConvert.DeserializeObject<ImportHallDto[]>(jsonString);

            var sb = new StringBuilder();
            var halls = new List<Hall>();

            foreach (var dto in hallDtos)
            {
                if (!IsValid(dto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var hall = new Hall
                {
                    Name = dto.Name,
                    Is4Dx = dto.Is4Dx,
                    Is3D = dto.Is3D,
                };

                for (int i = 0; i < dto.Seats; i++)
                {
                    var seat = new Seat
                    {
                        HallId = hall.Id
                    };

                    hall.Seats.Add(seat);
                }

                var projectionType = hall.Is3D ? "3D" : "4Dx";
                if (hall.Is3D && hall.Is4Dx)
                {
                    projectionType = "4Dx/3";
                }
                else if (hall.Is3D == false && hall.Is4Dx == false)
                {
                    projectionType = "Normal";
                }

                halls.Add(hall);

                sb.AppendLine(string.Format(SuccessfulImportHallSeat, hall.Name, projectionType, dto.Seats));
            }

            context.Halls.AddRange(halls);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportProjections(CinemaContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ImportProjectionDto[]),
                new XmlRootAttribute("Projections"));

            ImportProjectionDto[] projectionsDto;
            var sb = new StringBuilder();
            var projections = new List<Projection>();

            using (var reader = new StringReader(xmlString))
            {
                projectionsDto = (ImportProjectionDto[])serializer.Deserialize(reader);
            }

            foreach (var dto in projectionsDto)
            {
                var movie = context.Movies.FirstOrDefault(x => x.Id == dto.MovieId);
                var hall = context.Halls.FirstOrDefault(x => x.Id == dto.HallId);

                if (!IsValid(dto) || movie == null || hall == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var projection = new Projection
                {
                    MovieId = dto.MovieId,
                    HallId = dto.HallId,
                    DateTime = DateTime.ParseExact(dto.DateTime, "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture),
                    Movie = movie,
                    Hall = hall
                };

                projections.Add(projection);

                var datatime = projection.DateTime.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);


                sb.AppendLine(string.Format(SuccessfulImportProjection, movie.Title, datatime));
            }

            context.Projections.AddRange(projections);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportCustomerTickets(CinemaContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(ImportCustomersDto[]),
                new XmlRootAttribute("Customers"));

            ImportCustomersDto[] customersDto;
            var sb = new StringBuilder();
            var customers = new List<Customer>();

            using (var reader = new StringReader(xmlString))
            {
                customersDto = (ImportCustomersDto[])serializer.Deserialize(reader);
            }

            foreach (var custdto in customersDto)
            {
                if (!IsValid(custdto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var customer = new Customer
                {
                    FirstName = custdto.FirstName,
                    LastName = custdto.LastName,
                    Age = custdto.Age,
                    Balance = custdto.Balance,
                };

                foreach (var ticketDto in custdto.Tickets)
                {
                    var ticket = new Ticket
                    {
                        CustomerId = customer.Id,
                        ProjectionId = ticketDto.ProjectionId,
                        Price = ticketDto.Price
                    };

                    customer.Tickets.Add(ticket);
                    customers.Add(customer);
                }

                sb.AppendLine(string.Format(SuccessfulImportCustomerTicket, customer.FirstName, customer.LastName, customer.Tickets.Count));
            }

            context.Customers.AddRange(customers);
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
    }
}