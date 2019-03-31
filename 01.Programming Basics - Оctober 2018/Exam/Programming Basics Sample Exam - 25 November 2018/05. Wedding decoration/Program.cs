using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wedding_decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double bidjet = double.Parse(Console.ReadLine());
            double budget = 0;

            double balloons = 0.10;
            double flowers = 1.50;
            double candles = 0.50;
            double ribbon = 2.00;

            double balloonsSum = 0;
            double flowersSum = 0;
            double candlesSum = 0;
            double ribbonSum = 0;

            while (budget <= bidjet)
            {
                string stock = Console.ReadLine();
                if (stock == "stop")
                {
                    Console.WriteLine($"Spend money: {budget:F2}");
                    Console.WriteLine($"Money left: {bidjet - budget:F2}");
                    break;
                }
                double quantity = double.Parse(Console.ReadLine());

                if (stock == "balloons")
                {
                    budget += quantity * balloons;
                    balloonsSum += quantity;
                }
                else if (stock == "flowers")
                {
                    budget += quantity * flowers;
                    flowersSum += quantity;
                }
                else if (stock == "candles")
                {
                    budget += quantity * candles;
                    candlesSum += quantity;
                }
                else if (stock == "ribbon")
                {
                    budget += quantity * ribbon;
                    ribbonSum += quantity;
                }

            }
            Console.WriteLine("All money is spent!");
            Console.WriteLine($"Purchased decoration is {balloonsSum} balloons, {ribbonSum} m ribbon, {flowersSum} flowers and {candlesSum} candles.");

        }
    }
}
