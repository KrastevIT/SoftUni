using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02_Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] symbols = Console.ReadLine().Split();

            string regex = @"^(([d-z]+[{},|#]*)+)";

            var decode = Regex.Matches(input, regex);

            if (decode.Count == 0)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            string start = decode[0].Value;

            if (input.ToString() != start)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }

            string valid = string.Empty;

            foreach (var item in decode)
            {
                valid = item.ToString();
            }

            var builder = new StringBuilder();

            for (int i = 0; i < valid.Length; i++)
            {
                int by3Symbols = valid[i] - 3;

                char point = (char)by3Symbols;
                string letters = point.ToString();

                builder.Append(letters);
            }

            string lettersSearch = symbols[0];
            string lettersCorenct = symbols[1];

            builder.Replace(lettersSearch, lettersCorenct);

            Console.WriteLine(builder);

        }
    }
}
