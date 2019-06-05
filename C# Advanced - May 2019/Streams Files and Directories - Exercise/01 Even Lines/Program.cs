using System;
using System.IO;
using System.Linq;

namespace _01_Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string texFilePath = @"../../../text.txt";

            int counter = 0;

            using (StreamReader streamReader = new StreamReader(texFilePath))
            {
                string currentLine = streamReader.ReadLine();

                while (currentLine != null)
                {
                    if (counter % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSpecialCharacters(currentLine);
                        string reversedWords = ReverseWords(replacedSymbols);

                        Console.WriteLine(reversedWords);
                    }

                    currentLine = streamReader.ReadLine();

                    counter++;
                }
            }
        }

        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSpecialCharacters(string currentLine)
        {
            return currentLine.Replace("-", "@")
                  .Replace(",", "@")
                  .Replace(".", "@")
                  .Replace("!", "@")
                  .Replace("?", "@");
        }
    }
}
