using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int broqGrupa = int.Parse(Console.ReadLine());

            double vsichkiHora = 0;

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;


            for (int i = 1; i <= broqGrupa; i++)
            {
                double number = double.Parse(Console.ReadLine());
                vsichkiHora += number;

                if (number <= 5)
                {
                    musala += number;
                }
                else if (number >= 6 && number <= 12)
                {
                    monblan += number;
                }
                else if (number >= 13 && number <= 25)
                {
                    kilimandjaro += number;
                }
                else if (number >= 26 && number <= 40)
                {
                    k2 += number;
                }
                else if (number > 40)
                {
                    everest += number;
                }
            }
            Console.WriteLine($"{musala / vsichkiHora * 100:F2}%");
            Console.WriteLine($"{monblan / vsichkiHora * 100:F2}%");
            Console.WriteLine($"{kilimandjaro / vsichkiHora * 100:F2}%");
            Console.WriteLine($"{k2 / vsichkiHora * 100:F2}%");
            Console.WriteLine($"{everest / vsichkiHora * 100:F2}%");

        }
    }
}
