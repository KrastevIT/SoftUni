using System;

namespace _05_Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string numbers = string.Empty;
            string text = string.Empty;
            string symbol = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers += string.Concat(input[i]);
                }
                else if (char.IsLetter(input[i]))
                {
                    text += string.Concat(input[i]);
                }
                else
                {
                    symbol += string.Concat(input[i]);
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(text);
            Console.WriteLine(symbol);
        }
    }
}
