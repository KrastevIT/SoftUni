using System;

namespace _01_Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceKg = double.Parse(Console.ReadLine());

            double priceEgg = priceKg * 1.75 - priceKg;
            double priceMilk = (priceKg * 1.25) * 0.25;
            double totalPriceForCozonacs = priceKg + priceEgg + priceMilk;

            int egg = 0;
            int cozonacs = 0;
            double currentBudget = budget;
            int index = 0;

            // 2.79 for 3 egg
            while (currentBudget > totalPriceForCozonacs)
            {
                index++;
                if (currentBudget > totalPriceForCozonacs)
                {
                    double priceAfter = currentBudget - totalPriceForCozonacs;
                    egg += 3;
                    cozonacs++;
                    currentBudget -= totalPriceForCozonacs;
                }
                if (index % 3 == 0)
                {
                    int eggNum = cozonacs - 2;
                    egg -= eggNum;
                }

            }

            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {egg} eggs and {currentBudget:F2}BGN left.");

        }
    }
}
