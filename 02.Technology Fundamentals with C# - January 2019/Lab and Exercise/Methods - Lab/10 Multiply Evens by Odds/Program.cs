using System;
using System.Linq;

namespace _10_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            while (number != 0)
            {
                int lastDigit = Math.Abs(number % 10);
                int returnDigit = number / 10;
                number = returnDigit;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                else
                {
                    oddSum += lastDigit;
                }
            }
            int totalSum = evenSum * oddSum;
            Console.WriteLine(totalSum);
        }
    }
}
