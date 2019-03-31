using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFishermen = int.Parse(Console.ReadLine());

            double price = 0;

            if (season == "Spring")
            {
                if (numberFishermen % 2 == 0)
                {
                    price = 2850;
                }
                else if (numberFishermen % 2 == 1)
                {
                    price = 3000;
                }
            }
            else if (season == "Summer")
            {
                if (numberFishermen % 2 == 0)
                {
                    price = 3990;
                }
                else if (numberFishermen % 2 == 1)
                {
                    price = 4200;
                }
            }
            else if (season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                if (numberFishermen % 2 == 0)
                {
                    price = 2470;
                }
                else if (numberFishermen % 2 == 1)
                {
                    price = 2600;
                }
            }

            if (numberFishermen <= 6)
            {
                price = price * 0.90;
            }
            else if (numberFishermen >= 7 && numberFishermen <= 11)
            {
                price = price * 0.85;
            }
            else if (numberFishermen >= 12)
            {
                price = price * 0.75;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else if (budget < price)
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
            }
        }
    }
}
