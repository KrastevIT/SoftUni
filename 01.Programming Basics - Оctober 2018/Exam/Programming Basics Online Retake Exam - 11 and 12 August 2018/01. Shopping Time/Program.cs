using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shopping_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeBreak = int.Parse(Console.ReadLine());
            double pricePart = double.Parse(Console.ReadLine());
            double priceProgram = double.Parse(Console.ReadLine());
            double priceFrappe = double.Parse(Console.ReadLine());

            double whiteFrappe = timeBreak - 5;
            double restTime = 3 * 2;
            double bonus = 2 * 2;
            double relax = whiteFrappe - (restTime + bonus);

            double periphery = 3 * pricePart;
            double program = 2 * priceProgram;
            double allSum = program + periphery + priceFrappe;

            Console.WriteLine($"{allSum:F2}");
            Console.WriteLine(relax);
        }
    }
}
