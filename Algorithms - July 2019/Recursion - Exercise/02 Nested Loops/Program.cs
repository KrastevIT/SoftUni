using System;

namespace _02_Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            Combinations(vector, 0);
        }

        private static void Combinations(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 1; i <= vector.Length; i++)
                {
                    vector[index] = i;
                    Combinations(vector, index + 1);
                }

            }
        }
    }
}
