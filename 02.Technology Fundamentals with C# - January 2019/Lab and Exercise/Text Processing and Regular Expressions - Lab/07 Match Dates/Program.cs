using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDates = Console.ReadLine();

            string regex = @"\b(?<day>\d{2})(?<symbol>[-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

            var matched = Regex.Matches(inputDates, regex);

            foreach (Match date in matched)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
