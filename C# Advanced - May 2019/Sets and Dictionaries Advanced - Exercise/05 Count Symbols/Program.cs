using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbolsCount = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (!symbolsCount.ContainsKey(currentChar))
                {
                    symbolsCount[currentChar] = 0;
                }

                symbolsCount[currentChar]++;
            }

            foreach (var item in symbolsCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
