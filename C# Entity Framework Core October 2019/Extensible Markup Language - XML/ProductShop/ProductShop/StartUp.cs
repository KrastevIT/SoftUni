using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var db = new ProductShopContext())
            {
                // var inputXml = File.ReadAllText("./../../../Datasets/categories-products.xml");

                var result = GetUsersWithProducts(db);

                Console.WriteLine(result);
            }

        }

        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(UserDto[]),
                new XmlRootAttribute("Users"));

            UserDto[] userDtos;

            using (var reader = new StringReader(inputXml))
            {
                userDtos = (UserDto[])serializer.Deserialize(reader);
            }

            var users = userDtos
                .Select(u => new User
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age
                })
                .ToArray();

            context.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Length}";
        }

        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ProductDto[]),
                new XmlRootAttribute("Products"));

            ProductDto[] productDtos;

            using (var reader = new StringReader(inputXml))
            {
                productDtos = (ProductDto[])serializer.Deserialize(reader);
            }

            var products = productDtos
                .Select(p => new Product
                {
                    Name = p.Name,
                    Price = p.Price,
                    SellerId = p.SellerId,
                    BuyerId = p.BuyerId
                })
                .ToArray();

            context.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }

        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(CategoryDto[]),
                new XmlRootAttribute("Categories"));

            CategoryDto[] categoryDtos;

            using (var reader = new StringReader(inputXml))
            {
                categoryDtos = (CategoryDto[])serializer.Deserialize(reader);
            }

            var categories = categoryDtos
                .Where(c => c.Name != null)
                .Select(c => new Category
                {
                    Name = c.Name
                })
                .ToArray();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Length}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(CategoryProductDto[]),
                new XmlRootAttribute("CategoryProducts"));

            CategoryProductDto[] categoryProductDtos;

            using (var reader = new StringReader(inputXml))
            {
                categoryProductDtos = (CategoryProductDto[])serializer.Deserialize(reader);
            }

            var categoriesProducts = categoryProductDtos
                .Where(cp => cp.CategoryId != 0 && cp.ProductId != 0)
                .Select(cp => new CategoryProduct
                {
                    CategoryId = cp.CategoryId,
                    ProductId = cp.ProductId
                })
                .ToArray();

            context.CategoryProducts.AddRange(categoriesProducts);
            context.SaveChanges();

            return $"Successfully imported {categoriesProducts.Length}";
        }

        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .OrderBy(p => p.Price)
                .Select(p => new ProductInRangeDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = p.Buyer.FirstName + ' ' + p.Buyer.LastName
                })
                .Take(10)
                .ToArray();

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var serializer = new XmlSerializer(typeof(ProductInRangeDto[]),
                new XmlRootAttribute("Products"));

            var productsXml = new StringBuilder();

            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, products, ns);

                productsXml = writer.GetStringBuilder();
            }

            return productsXml.ToString().TrimEnd();
        }

        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
               .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
               .OrderBy(u => u.LastName)
               .ThenBy(u => u.FirstName)
               .Select(u => new ExportUserDto
               {
                   FirstName = u.FirstName,
                   LastName = u.LastName,
                   SoldProducts = u.ProductsSold
                       .Where(ps => ps.Buyer != null)
                       .Select(ps => new UserProductDto
                       {
                           Name = ps.Name,
                           Price = ps.Price
                       })
                       .ToArray()
               })
               .Take(5)
               .ToArray();

            using var writer = new StringWriter();

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var serializer = new XmlSerializer(typeof(ExportUserDto[]), new XmlRootAttribute("Users"));
            serializer.Serialize(writer, users, ns);

            var soldProductsXml = writer.GetStringBuilder();

            return soldProductsXml.ToString().TrimEnd();
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categoryDtos = context.Categories
                .Select(c => new CategoryByProductDto
                {
                    Name = c.Name,
                    Count = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts
                        .Average(p => p.Product.Price),
                    TotalRevenue = c.CategoryProducts
                        .Sum(p => p.Product.Price)
                })
                .OrderByDescending(c => c.Count)
                .ThenBy(c => c.TotalRevenue)
                .ToArray();

            using var writer = new StringWriter();

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var serializer = new XmlSerializer(
                typeof(CategoryByProductDto[]),
                new XmlRootAttribute("Categories"));
            serializer.Serialize(writer, categoryDtos, ns);

            var result = writer.GetStringBuilder();

            return result.ToString().TrimEnd();
        }

        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any())
                .OrderByDescending(p => p.ProductsSold.Count())
                .Select(u => new UserWithProductsDto
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new SoldProductDto
                    {
                        Count = u.ProductsSold.Count(),
                        Products = u.ProductsSold
                            .Select(p => new ExportProductDto
                            {
                                Name = p.Name,
                                Price = p.Price
                            })
                            .OrderByDescending(p => p.Price)
                            .ToArray()
                    }
                })
                .Take(10)
                .ToArray();

            var userAndProducts = new UserAndProductsDto
            {
                Count = context.Users.Count(u => u.ProductsSold.Any()),
                Users = users
            };

            using var writer = new StringWriter();

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            var serializer = new XmlSerializer(typeof(UserAndProductsDto), new XmlRootAttribute("Users"));
            serializer.Serialize(writer, userAndProducts, ns);

            var userAndProductsXml = writer.GetStringBuilder();

            return userAndProductsXml.ToString().TrimEnd();
        }
    }
}