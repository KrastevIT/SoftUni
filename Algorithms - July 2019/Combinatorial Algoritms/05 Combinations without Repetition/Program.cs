using System;
using System.Linq;

namespace _05_Combinations_without_Repetition
{
    class Program
    {
        static char[] elements;
        static char[] permute;


        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
               .Split()
               .Select(char.Parse)
               .ToArray();

            int limit = int.Parse(Console.ReadLine());

            elements = new char[input.Length];
            elements = input;
            permute = new char[limit];

            Combinations(0, 0);
        }

        private static void Combinations(int index, int start)
        {
            if (index == permute.Length)
            {
                Console.WriteLine(string.Join(" ", permute));
            }
            else
            {
                for (int i = start; i < elements.Length; i++)
                {
                    permute[index] = elements[i];

                    Combinations(index + 1, i + 1);

                }
            }
        }
    }
}
