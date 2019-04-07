using System;
using System.Collections.Generic;
using System.Linq;

namespace _04TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodExpenses = double.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());

            if (groupOfPeople > 10)
            {
                priceForNight *= 0.75;
            }

            double expenses = (foodExpenses + priceForNight) * groupOfPeople * daysOfTrip;

            for (int i = 1; i <= daysOfTrip; i++)
            {
                double travelDistance = double.Parse(Console.ReadLine());

                expenses += travelDistance * fuelPerKilometer;

                if (i % 3 == 0)
                {
                    expenses *= 1.4;
                }
                if (i % 5 == 0)
                {
                    expenses *= 1.4;
                }
                if (i % 7 == 0)
                {
                    expenses -= expenses / groupOfPeople;
                }
            }

            if (expenses > budget)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {(expenses - budget):f2}$ more.");
                return;
            }

            Console.WriteLine($"You have reached the destination. You have {(budget - expenses):f2}$ budget left.");
        }

    }
}
