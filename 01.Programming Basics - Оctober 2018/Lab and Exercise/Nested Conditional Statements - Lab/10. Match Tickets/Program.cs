using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int fans = int.Parse(Console.ReadLine());
            double ticketPrice = 0;
            double moneyForTravel = 0;
            double finalSum = 0;

            if (ticketCategory == "VIP")
            {
                ticketPrice = 499.99;
            }
            else
            {
                ticketPrice = 249.99;
            }

            if (fans >= 1 && fans <5)
            {
                moneyForTravel = budget * 0.75;
                finalSum = budget - moneyForTravel;
            }
            else if (fans >=5 && fans < 10)
            {
                moneyForTravel = budget * 0.60;
                finalSum = budget - moneyForTravel;
            }
            else if (fans >=10 && fans < 25)
            {
                moneyForTravel = budget * 0.50;
                finalSum = budget - moneyForTravel;
            }
            else if (fans >= 25 && fans < 50)
            {
                moneyForTravel = budget * 0.40;
                finalSum = budget - moneyForTravel;
            }
            else if (fans >= 50)
            {
                moneyForTravel = budget * 0.25;
                finalSum = budget - moneyForTravel;
            }

            finalSum = finalSum - (fans * ticketPrice);

            if (finalSum >= 0)
            {
                Console.WriteLine($"Yes! You have {finalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(finalSum):F2} leva.");
            }

        }
    }
}
