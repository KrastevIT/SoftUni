using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double num = 0;
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }

            if (n == 0)
            {
                Console.WriteLine($"OddSum={oddSum}, OddMin=No, OddMax=No, EvenSum={evenSum}, EvenMin=No, EvenMax=No");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum={oddSum}, OddMin={oddMin}, OddMax={oddMax}, EvenSum={evenSum}, EvenMin=No, EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum}, OddMin={oddMin}, OddMax={oddMax}, EvenSum={evenSum}, EvenMin={evenMin}, EvenMax={evenMax}");
            }
        }
    }
}

