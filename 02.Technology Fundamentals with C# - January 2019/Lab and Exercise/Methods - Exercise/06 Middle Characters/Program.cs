using System;

namespace _06_Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleSymbols(input);
        }

        private static void PrintMiddleSymbols(string input)
        {
            int sum = 0;
            for (int i = 0; i <= input.Length; i++)
            {
                sum++;
            }
            int newSum = sum / 2;
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[newSum - 1]}{input[newSum]}");
            }
            else
            {
                Console.WriteLine(input[newSum-1]);
            }
        }
    }
}
