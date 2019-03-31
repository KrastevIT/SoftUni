using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            int last = 0;
            double allSum = 0;
            double sumLast = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                last = number % 10;
                int beforeLast = number / 10;


                if (last == 2)
                {
                    sum = 0;
                }
                else if (last == 3)
                {
                    sum = beforeLast * 0.50;
                }
                else if (last == 4)
                {
                    sum = beforeLast * 0.70;
                }
                else if (last == 5)
                {
                    sum = beforeLast * 0.85;
                }
                else if (last == 6)
                {
                    sum = beforeLast * 1.00;
                }
                allSum += sum;
                sumLast += last;

            }

            Console.WriteLine($"{allSum:F2}");
            Console.WriteLine($"{sumLast / n:F2}");
        }
    }
}
