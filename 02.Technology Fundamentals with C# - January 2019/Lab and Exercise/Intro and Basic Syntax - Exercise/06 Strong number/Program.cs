using System;
using System.Linq;
namespace _06_Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int originNumber = int.Parse(Console.ReadLine());
            int number = originNumber;
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;

                int currentFactorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    currentFactorial *= i;
                }
                sum += currentFactorial;
            }

            if (originNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
