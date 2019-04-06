using System;

namespace _01_Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double kilometer = double.Parse(Console.ReadLine());
            double foodExpenses = double.Parse(Console.ReadLine());
            double priceForNight = double.Parse(Console.ReadLine());

            double totalSumForExpenses = 0;
            double foodPrice = foodExpenses * groupOfPeople * daysOfTrip;
            double hotelPrice = priceForNight * groupOfPeople * daysOfTrip;
            double firstSum = foodPrice + hotelPrice;
            totalSumForExpenses += firstSum;

            double receiveMoney = 0;

            if (groupOfPeople > 10)
            {
                double discount = hotelPrice * 0.25;
                hotelPrice -= discount;
            }

            for (int i = 1; i < daysOfTrip; i++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());

                double currentExpenses = travelledDistance * kilometer;

                if (i % 3 == 0)
                {
                    double addSum = currentExpenses * 0.4;
                    totalSumForExpenses += addSum;

                }
                if (i % 5 == 0)
                {
                    double addSum = currentExpenses * 0.4;
                    totalSumForExpenses += addSum;
                }
                if (i % 7 == 0)
                {
                    receiveMoney += currentExpenses / groupOfPeople;
                    totalSumForExpenses += receiveMoney;
                }

                totalSumForExpenses += currentExpenses;
            }
            double resultSum = totalSumForExpenses / groupOfPeople;

            Console.WriteLine(totalSumForExpenses);
        }
    }
}
