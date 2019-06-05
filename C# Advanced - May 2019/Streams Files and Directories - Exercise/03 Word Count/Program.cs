using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordsPath = "words.txt";

            string[] textLines = File.ReadAllLines(textPath);
            string[] words = File.ReadAllLines(wordsPath);

            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWordToLowerCase = word.ToLower();

                if (!wordsInfo.ContainsKey(currentWordToLowerCase))
                {
                    wordsInfo.Add(currentWordToLowerCase, 0);
                }
            }

            foreach (var currentLine in textLines)
            {
                string[] currentLineWords = currentLine
                    .ToLower()
                    .Split(new char[] { ' ', '-', ',', '?', '!', '.', '\'', ':', ';' });

                foreach (var currentWord in currentLineWords)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    {
                        wordsInfo[currentWord]++;
                    }
                }
            }

            string actualResultPath = "actualResult.txt";
            string expectedResultPath = "expectedResult.txt";

            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText(actualResultPath, $"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }
        }
    }
}
