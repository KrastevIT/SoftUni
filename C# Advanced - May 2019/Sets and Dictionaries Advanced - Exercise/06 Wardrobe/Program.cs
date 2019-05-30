using System;
using System.Collections.Generic;

namespace _06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var clothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string colors = input[0];
                string[] items = input[1].Split(',');

                for (int k = 0; k < items.Length; k++)
                {
                    string item = items[k];

                    if (!clothes.ContainsKey(colors))
                    {
                        clothes[colors] = new Dictionary<string, int>();
                    }

                    if (!clothes[colors].ContainsKey(item))
                    {
                        clothes[colors].Add(item, 1);
                    }
                    else
                    {
                        clothes[colors][item]++;
                    }
                }
            }

            string[] finalInput = Console.ReadLine().Split();

            string color = finalInput[0];
            string finalItem = finalInput[1];

            foreach (var kvp in clothes)
            {
                Console.WriteLine($"{kvp.Key} clothes:");

                foreach (var values in kvp.Value)
                {
                    if (color == kvp.Key && values.Key == finalItem)
                    {
                        Console.WriteLine($"* {values.Key} - {values.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {values.Key} - {values.Value}");
                    }
                }
            }
        }
    }
}
