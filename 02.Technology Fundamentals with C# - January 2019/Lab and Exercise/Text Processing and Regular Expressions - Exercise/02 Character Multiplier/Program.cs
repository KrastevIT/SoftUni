using System;

namespace _02_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];

            string big = string.Empty;
            string small = string.Empty;

            if (first.Length >= second.Length)
            {
                big = first;
                small = second;
            }
            else
            {
                big = second;
                small = first;
            }

            int totalSum = 0;

            for (int i = 0; i < small.Length; i++)
            {
                totalSum += small[i] * big[i];
            }

            for (int i = small.Length; i < big.Length; i++)
            {
                totalSum += big[i];
            }

            Console.WriteLine(totalSum);
        }
    }
}
