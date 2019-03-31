using System;
using System.Linq;

namespace _02_Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            PrintVowels(input);
        }

        static void PrintVowels(string input)
        {
            int couter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    couter++;
                }
                if (input[i] == 'e')
                {
                    couter++;
                }
                if (input[i] == 'i')
                {
                    couter++;
                }
                if (input[i] == 'o')
                {
                    couter++;
                }
                if (input[i] == 'u')
                {
                    couter++;
                }
            }
            Console.WriteLine(couter);

        }
    }
}
