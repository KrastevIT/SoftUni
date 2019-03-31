using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inputProducts = Console.ReadLine().Split();
            var products = new Dictionary<string, List<double>>();

            while (inputProducts[0] != "buy")
            {
                string nameProduct = inputProducts[0];
                double price = double.Parse(inputProducts[1]);
                double quantity = double.Parse(inputProducts[2]);

                if (!products.ContainsKey(nameProduct))
                {
                    products[nameProduct] = new List<double>();
                    products[nameProduct].Add(price);
                    products[nameProduct].Add(quantity);
                }
                else
                {
                    products[nameProduct][1] += quantity;
                    if (products[nameProduct][0] != price)
                    {
                        products[nameProduct][0] = price;
                    }
                }

                inputProducts = Console.ReadLine().Split();
            }

            foreach (var item in products)
            {
                double totalSum = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalSum:F2}");
            }
        }
    }
}
