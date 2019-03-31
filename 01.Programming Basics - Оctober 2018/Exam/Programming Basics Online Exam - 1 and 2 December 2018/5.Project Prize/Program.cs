using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Project_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double parichnaNagrada = double.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number * 2;


                }
                else
                {
                    oddSum += number;
                }
            }
            double allSum = evenSum + oddSum;
            double nagradata = parichnaNagrada * allSum;
            Console.WriteLine($"The project prize was {nagradata:F2} lv.");

        }
    }
}
