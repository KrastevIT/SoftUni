using System;
using System.Linq;

namespace _05_Combinations_without_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            int start = 1;

            Combinations(0, arr, start, end);
        }

        private static void Combinations(int index, int[] arr, int start, int end)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    Combinations(index + 1, arr, i + 1, end);
                    start++;
                }
            }
        }
    }
}
