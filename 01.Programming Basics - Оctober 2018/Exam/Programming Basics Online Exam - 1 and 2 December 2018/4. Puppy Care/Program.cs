using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumFood = int.Parse(Console.ReadLine());

            double grama = sumFood * 1000;

            string sumEat = Console.ReadLine();

            double allSum = 0;

            while (sumEat != "Adopted")
            {
                double number = double.Parse(sumEat);

                allSum += number;

                sumEat = Console.ReadLine();
            }


            if (allSum <= grama)
            {
                Console.WriteLine($"Food is enough! Leftovers: {grama - allSum} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {allSum - grama} grams more.");
            }
        }
    }
}
