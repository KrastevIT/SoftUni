using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceParty = double.Parse(Console.ReadLine());
            int numMessages = int.Parse(Console.ReadLine());
            int numWax = int.Parse(Console.ReadLine());
            int numKeys = int.Parse(Console.ReadLine());
            int numCartoon = int.Parse(Console.ReadLine());
            int numLuck = int.Parse(Console.ReadLine());

            double hosting = 0;
            double profit = 0;

            double sum = numMessages * 0.60 + numWax * 7.20 + numKeys * 3.60 + numCartoon * 18.20 + numLuck * 22.00;
            double articles = numMessages + numWax + numKeys + numCartoon + numLuck;

            if (articles >= 25)
            {
                double discount = sum * 0.35;
                double finalPrice = sum - discount;

                hosting = finalPrice * 0.10;
                profit = finalPrice - hosting;

            }
            else
            {
                hosting = sum * 0.10;
                profit = sum - hosting;
            }

            if (profit >= priceParty)
            {
                double allSum = profit - priceParty;
                Console.WriteLine($"Yes! {allSum} lv left.");
            }
            else
            {
                double allSum = priceParty - profit;
                Console.WriteLine($"Not enough money! {allSum} lv needed.");
            }
        }
    }
}
