using System;
using System.Linq;

namespace _07_Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool test = false;

            for (int k = 0; k < firstNumbers.Length; k++)
            {
                sum += firstNumbers[k];
            }

            for (int i = 0; i < firstNumbers.Length; i++)
            {
                if (firstNumbers[i] != secondNumbers[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    test = true;
                    break;
                }
            }

            if (test == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
