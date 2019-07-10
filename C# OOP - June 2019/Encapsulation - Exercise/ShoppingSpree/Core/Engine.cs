using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        private List<Person> persons;
        private List<Product> products;
        public Engine()
        {
            this.persons = new List<Person>();
            this.products = new List<Product>();
        }

        public void Run()
        {
            try
            {
                ReadPersonsInput();
                ReadProductsInput();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] commandTokens = command
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string personName = commandTokens[0];
                    string productName = commandTokens[1];

                    Person person = persons
                        .FirstOrDefault(p => p.Name == personName);

                    Product product = products
                        .FirstOrDefault(p => p.Name == productName);

                    if (persons != null && product != null)
                    {
                        person.BuyProduct(product);

                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                }
                catch (InvalidOperationException inv)
                {
                    Console.WriteLine(inv.Message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, persons));

        }

        private void ReadProductsInput()
        {
            string[] productsInfo = Console.ReadLine()
                                       .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var pt in productsInfo)
            {
                string[] productInfo = pt.Split("=");

                string name = productInfo[0];
                decimal cost = decimal.Parse(productInfo[1]);

                Product product = new Product(name, cost);

                products.Add(product);
            }
        }

        private void ReadPersonsInput()
        {
            string[] personTokens = Console.ReadLine()
                            .Split(";", StringSplitOptions.RemoveEmptyEntries);

            foreach (var pt in personTokens)
            {
                string[] personInfo = pt.Split("=");

                string name = personInfo[0];
                decimal money = decimal.Parse(personInfo[1]);

                Person person = new Person(name, money);

                persons.Add(person);
            }
        }
    }
}
