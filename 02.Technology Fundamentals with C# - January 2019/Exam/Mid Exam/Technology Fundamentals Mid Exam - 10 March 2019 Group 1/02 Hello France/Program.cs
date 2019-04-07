using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Hello_France
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");
            double budget = double.Parse(Console.ReadLine());

            var finalPrice = new List<double>();
            double profit = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string[] splitProducts = input[i].Split("->");

                string product = splitProducts[0];
                double price = double.Parse(splitProducts[1]);

                if (product == "Clothes")
                {
                    if (price <= 50.00 && budget >= price)
                    {
                        budget -= price;
                        profit += price * 0.40;
                        finalPrice.Add(price * 1.40);
                    }
                }
                else if (product == "Shoes")
                {
                    if (price <= 35.00 && budget >= price)
                    {
                        budget -= price;
                        profit += price * 0.40;
                        finalPrice.Add(price * 1.40);
                    }
                }
                else if (product == "Accessories")
                {
                    if (price <= 20.50 && budget >= price)
                    {
                        budget -= price;
                        profit += price * 0.40;
                        finalPrice.Add(price * 1.40);
                    }
                }
            }

            foreach (var number in finalPrice)
            {
                Console.Write($"{number:F2}" + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Profit: {profit:F2}");

            if (budget + finalPrice.Sum() >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
