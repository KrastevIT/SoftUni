using System;
using System.Linq;

namespace _06_Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();
            int[] arrNumbers = inputNumbers.Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                if (arrNumbers[i] % 2 == 0)
                {
                    evenSum += arrNumbers[i];
                }
                else
                {
                    oddSum += arrNumbers[i];
                }
            }

            Console.WriteLine($"{evenSum - oddSum}");
        }
    }
}
