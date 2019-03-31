using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int order = int.Parse(Console.ReadLine());

            double gell = 0;
            double percent = 0;
            double allSum = 0;

            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    gell = 56.00 * 2;
                }
                else if (size == "big")
                {
                    gell = 28.70 * 5;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    gell = 36.66 * 2;
                }
                else if (size == "big")
                {
                    gell = 19.60 * 5;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    gell = 42.10 * 2;
                }
                else if (size == "big")
                {
                    gell = 24.80 * 5;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    gell = 20.00 * 2;
                }
                else if (size == "big")
                {
                    gell = 15.20 * 5;
                }
            }

            double priceSet = gell * order;

            if (priceSet >= 400 && priceSet <= 1000)
            {
                percent = priceSet * 0.15;
                allSum = priceSet - percent;
            }
            else if (priceSet > 1000)
            {
                percent = priceSet * 0.50;
                allSum = priceSet - percent;

            }
            else if (priceSet < 400)
            {
                allSum = gell;
            }
            Console.WriteLine($"{allSum:F2} lv.");
        }
    }
}
