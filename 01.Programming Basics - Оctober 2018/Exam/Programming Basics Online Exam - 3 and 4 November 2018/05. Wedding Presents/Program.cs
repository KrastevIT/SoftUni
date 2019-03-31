using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wedding_Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double gifts = double.Parse(Console.ReadLine());

            double a = 0;
            double b = 0;
            double v = 0;
            double g = 0;

            for (int i = 1; i <= gifts; i++)
            {
                string symbol = Console.ReadLine();

                if (symbol == "A")
                {
                    a += 1;
                }
                else if (symbol == "B")
                {
                    b += 1;
                }
                else if (symbol == "V")
                {
                    v += 1;
                }
                else if (symbol == "G")
                {
                    g += 1;
                }
            }

            Console.WriteLine($"{a / gifts * 100:F2}%");
            Console.WriteLine($"{b / gifts * 100:F2}%");
            Console.WriteLine($"{v / gifts * 100:F2}%");
            Console.WriteLine($"{g / gifts * 100:F2}%");
            Console.WriteLine($"{gifts / guests * 100:F2}%");


        }
    }
}
