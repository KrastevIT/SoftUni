using System;
using System.Linq;

namespace _03_Inversion_Count
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            InversionCount(input, input.Length - 1);
        }

        private static void InversionCount(int[] input, int end)
        {
            for (int i = 0; i <= end; i++)
            {
                for (int k = i; k <= end; k++)
                {
                    if (input[i] > input[k])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
