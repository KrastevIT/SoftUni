using System;


namespace _06.Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            int numberSweet = int.Parse(Console.ReadLine());
            int numberCakes = int.Parse(Console.ReadLine());
            int numberWaffles = int.Parse(Console.ReadLine());
            int numberPancakes = int.Parse(Console.ReadLine());

            double cake = 45;
            double wafer = 5.80;
            double pancake = 3.20;

            double sumCake = numberCakes * cake;
            double sumWafer = numberWaffles * wafer;
            double sumPancake = numberPancakes * pancake;

            double totalSumDay = (sumCake + sumWafer + sumPancake) * numberSweet;
            double totalSum = totalSumDay * numberDays;
            double sumAfterCosts = totalSum - (totalSum / 8);
            Console.WriteLine($"{sumAfterCosts:F2}");
        }
    }
}
