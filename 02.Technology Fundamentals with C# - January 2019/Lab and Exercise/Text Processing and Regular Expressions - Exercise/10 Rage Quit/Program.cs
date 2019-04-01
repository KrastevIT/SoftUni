using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _10_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine().ToUpper();
            string patternSymbols = @"(?<text>\D+)(?<number>\d+)";
            var regexSymbols = Regex.Matches(symbols, patternSymbols);

            StringBuilder newSymbols = new StringBuilder();

            int count = 0;

            foreach (Match match in regexSymbols)
            {
                string text = match.Groups["text"].Value;
                int number = int.Parse(match.Groups["number"].Value);

                for (int i = 0; i < number; i++)
                {
                    newSymbols.Append(text);
                }
            }

            count = newSymbols.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(newSymbols);
        }
    }
}
