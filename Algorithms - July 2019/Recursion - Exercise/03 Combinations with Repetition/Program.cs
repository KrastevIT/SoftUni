using System;

namespace _03_Combinations_with_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int lengthOfVector = int.Parse(Console.ReadLine());

            int[] vector = new int[lengthOfVector];

            int start = 1;

            Combinations(vector, 0, start, end);
        }

        private static void Combinations(int[] vector, int index, int start, int end)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    vector[index] = i;
                    Combinations(vector, index + 1, start, end);
                    start++;
                }
            }
        }
    }
}
