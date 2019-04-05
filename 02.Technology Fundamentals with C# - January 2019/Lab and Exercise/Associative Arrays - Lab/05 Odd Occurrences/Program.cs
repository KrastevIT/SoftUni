using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().ToLower().Split();

            var words = new Dictionary<string, int>();

            foreach (var symbol in symbols)
            {
                if (!words.ContainsKey(symbol))
                {
                    words[symbol] = 0;
                }

                words[symbol]++;
            }

            foreach (var kvp in words.Where(x => x.Value % 2 == 1))
            {
                Console.Write(kvp.Key + " ");
            }
        }
    }
}
