using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            var counts = new SortedDictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!counts.ContainsKey(num))
                {
                    counts[num] = 0;
                }

                counts[num]++;
            }

            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
