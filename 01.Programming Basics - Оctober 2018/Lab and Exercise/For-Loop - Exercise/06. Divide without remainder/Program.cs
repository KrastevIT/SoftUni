using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfLoops = int.Parse(Console.ReadLine());

            double Divide2 = 0.0;
            double Divide3 = 0.0;
            double Divide4 = 0.0;

            for (int Index = 0; Index < NumberOfLoops; Index++)
            {
                int Number = int.Parse(Console.ReadLine());

                if (Number % 2 == 0)
                {
                    Divide2++;
                }
                if (Number % 3 == 0)
                {
                    Divide3++;
                }
                if (Number % 4 == 0)
                {
                    Divide4++;
                }
            }

            double PercentOf2 = (Divide2 * 100) / NumberOfLoops;
            double PercentOf3 = (Divide3 * 100) / NumberOfLoops;
            double PercentOf4 = (Divide4 * 100) / NumberOfLoops;

            Console.WriteLine($"{PercentOf2:0.00}%");
            Console.WriteLine($"{PercentOf3:0.00}%");
            Console.WriteLine($"{PercentOf4:0.00}%");

        }
    }
}
