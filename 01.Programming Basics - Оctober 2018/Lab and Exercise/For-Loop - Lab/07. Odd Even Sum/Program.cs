using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }

            }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes Sum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No Diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }

}
