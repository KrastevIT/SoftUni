using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_Emoji_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> emojiCode = Console.ReadLine().Split(":").Select(int.Parse).ToList();

            List<string> emoji = new List<string>();
            int totalPower = 0;
            bool isEqual = false;

            string pattern = @"(?<= )[:][a-z]{4,}[:](?=[ ,.!?])";

            var matched = Regex.Matches(input, pattern);

            foreach (Match item in matched)
            {
                emoji.Add(item.ToString());
            }

            for (int i = 0; i < emoji.Count; i++)
            {
                string currentEmoji = emoji[i];
                var emojiSum = new List<int>();

                for (int j = 0; j < currentEmoji.Length; j++)
                {
                    int currentChar = currentEmoji[j];
                    int currentSum = 0;

                    if (currentChar == ':')
                    {
                        continue;
                    }

                    currentSum += currentChar;
                    emojiSum.Add(currentSum);
                }

                totalPower += emojiSum.Sum();

                if (emojiSum.SequenceEqual(emojiCode))
                {
                    isEqual = true;
                }
            }

            if (isEqual)
            {
                totalPower *= 2;
            }

            if (emoji.Count == 0)
            {
                Console.WriteLine($"Total Emoji Power: 0");
            }
            else
            {
                Console.WriteLine($"Emojis found: {string.Join(", ", emoji)}");
                Console.WriteLine($"Total Emoji Power: {totalPower}");
            }

        }
    }
}

