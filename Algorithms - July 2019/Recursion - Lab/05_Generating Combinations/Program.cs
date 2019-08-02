using System;
using System.Linq;

namespace _05_Generating_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Combinations(set, vector, 0, 0);

        }

        private static void Combinations(int[] set, int[] vector, int index, int border)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    Combinations(set, vector, index + 1, i + 1);
                }
            }
        }
    }
}
