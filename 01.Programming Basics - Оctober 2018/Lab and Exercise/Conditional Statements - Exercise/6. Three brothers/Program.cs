using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Three_brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());

            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherFishing = double.Parse(Console.ReadLine());

            double totalTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            double breakTime = totalTime * 0.15;
            breakTime = totalTime + breakTime;
            double residue = fatherFishing - breakTime;

            Console.WriteLine($"Cleaning time: {breakTime:F2}");

            if (fatherFishing < breakTime)
            {
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Floor(residue)} hours.");
            }
            else
            {
                Console.WriteLine($"Yes, there is a surprise - time left-> {Math.Floor(residue)} hours.");
            }
        }
    }
}
