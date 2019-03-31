using System;
using System.Collections.Generic;

namespace _04_List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfProducts = int.Parse(Console.ReadLine());

            PrintSortProducts(linesOfProducts);
        }

        private static void PrintSortProducts(int linesOfProducts)
        {
            List<string> products = new List<string>();

            for (int i = 0; i < linesOfProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }

        }
    }
}
