using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = 0;

            switch (name)
            {
                case "Roses":
                    if (number >= 80)
                    {
                        price = 5.00 * 0.90;
                    }
                    else if (number < 80)
                    {
                        price = 5.00;
                    }
                    break;
                case "Dahlias":
                    if (number >= 90)
                    {
                        price = 3.80 * 0.85;
                    }
                    else if (number < 90)
                    {
                        price = 3.80;
                    }
                    break;
                case "Tulips":
                    if (number >= 80)
                    {
                        price = 2.80 * 0.85;
                    }
                    else if (number < 80)
                    {
                        price = 2.80;
                    }
                    break;
                case "Narcissus":
                    if (number < 120)
                    {
                        price = 3.00 * 1.15;
                    }
                    else if (number >= 120)
                    {
                        price = 3.00;
                    }
                    break;
                case "Gladiolus":
                    if (number < 80)
                    {
                        price = 2.50 * 1.20;
                    }
                    else if (number >= 80)
                    {
                        price = 2.50;
                    }
                    break;
            }

            double sum = number * price;
            double remainingSum = budget - sum;
            double deficit = sum - budget;

            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {name} and {remainingSum:F2} leva left.");
            }
            else if (budget <= sum)
            {
                Console.WriteLine($"Not enough money, you need {deficit:F2} leva more.");
            }
        }
    }
}