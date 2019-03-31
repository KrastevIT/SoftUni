using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Wedding_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double sum = 0;

            double balloons = 0;
            double flowers = 0;
            double candles = 0;
            double ribbon = 0;

            while (budget > sum)
            {
                string type = Console.ReadLine();

                if (type == "stop")
                {
                    Console.WriteLine($"Spend money: {sum:F2}");
                    Console.WriteLine($"Money left: {budget - sum:F2}");
                    Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m " +
                        $"ribbon, {flowers} flowers and {candles} candles.");
                }

                double number = double.Parse(Console.ReadLine());

                if (type == "balloons")
                {
                    balloons += number;
                    sum += number * 0.10;
                }
                else if (type == "flowers")
                {
                    flowers += number;
                    sum += number * 1.50;
                }
                else if (type == "candles")
                {
                    candles += number;
                    sum += number * 0.50;
                }
                else if (type == "ribbon")
                {
                    ribbon += number;
                    sum += number * 2.00;
                }

            }

            if (sum >= budget)
            {
                Console.WriteLine("All money is spent!");
                Console.WriteLine($"Purchased decoration is {balloons} balloons, {ribbon} m " +
                    $"ribbon, {flowers} flowers and {candles} candles.");
            }
        }
    }
}
