using System;
using System.Linq;

namespace _10_Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 8; i < range; i++)
            {
                bool isDivisableBy8 = ChekIsDivisableBy8(i);

                bool containsOddNumber = CountainsOddNumber(i);

                if (isDivisableBy8 & containsOddNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CountainsOddNumber(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit %2 == 1)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ChekIsDivisableBy8(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                sum += digit;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
