using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Wedding_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double couvert = guests * 20;

            if (budget >= couvert)
            {
                double remainingMoney = budget - couvert;
                double fireworks = remainingMoney * 0.40;
                double donations = remainingMoney - fireworks;
                Console.WriteLine($"Yes! {fireworks:F2} lv are for fireworks and {donations:F2} lv are for donation.");
            }
            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {couvert - budget:F2} lv more.");
            }
        }
    }
}
