using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var alphabet = new Dictionary<string, int>();

            double totalSum = 0;

            char point = char.Parse("a");
            for (int i = 1; i <= 26; i++)
            {
                string letter = point.ToString();
                alphabet[letter] = i;
                point += (char)1;
            }

            string pattern = @"(?<firstText>[A-Za-z*])(?<number>[0-9]+)(?<secondText>[A-Za-z*])";
            var regex = Regex.Matches(input, pattern);

            foreach (Match match in regex)
            {
                string leftLatter = match.Groups["firstText"].ToString();
                int number = int.Parse(match.Groups["number"].ToString());
                string rightLatter = match.Groups["secondText"].ToString();

                double numberOfAlphabet = 0;

                if (alphabet.ContainsKey(leftLatter.ToLower()))
                {
                    numberOfAlphabet = alphabet[leftLatter.ToLower()];
                }

                if (char.IsUpper(leftLatter[0]))
                {
                    totalSum += number / numberOfAlphabet;
                }
                else
                {
                    totalSum += number * numberOfAlphabet;
                }

                if (alphabet.ContainsKey(rightLatter.ToLower()))
                {
                    numberOfAlphabet = alphabet[rightLatter.ToLower()];
                }

                if (char.IsUpper(rightLatter[0]))
                {
                    totalSum -= numberOfAlphabet;
                }
                else
                {
                    totalSum += numberOfAlphabet;
                }
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
