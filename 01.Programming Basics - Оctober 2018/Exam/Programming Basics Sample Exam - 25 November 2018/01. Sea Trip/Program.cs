using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyFood = double.Parse(Console.ReadLine());
            double moneySouvenir = double.Parse(Console.ReadLine());
            double moneyHotel = double.Parse(Console.ReadLine());

            double literGasoline = 29.40;
            double moneyForGasoline = literGasoline * 1.85;
            double foodSouvenir = 3 * moneyFood + 3 * moneySouvenir;

            double firstDay = moneyHotel * 0.9;
            double secoundDay = moneyHotel * 0.85;
            double thirdDay = moneyHotel * 0.8;
            double daysHotel = firstDay + secoundDay + thirdDay;

            double allSum = moneyForGasoline + foodSouvenir + daysHotel;
            Console.WriteLine($"Money needed: {allSum:F2}");

        }
    }
}
