using System;

namespace _01_Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfFlour = double.Parse(Console.ReadLine());
            double priceOfEgg = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());

            int freePackagesFlour = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freePackagesFlour++;
                }
            }

            double totalSum = priceOfApron * (Math.Ceiling(students * 0.20 + students))
                + priceOfEgg * 10 * students + priceOfFlour * (students - freePackagesFlour);

            if (totalSum <= budget)
            {
                Console.WriteLine($"Items purchased for {totalSum:F2}$.");
            }
            else
            {
                Console.WriteLine($"{totalSum - budget:F2}$ more needed.");
            }
        }
    }
}
