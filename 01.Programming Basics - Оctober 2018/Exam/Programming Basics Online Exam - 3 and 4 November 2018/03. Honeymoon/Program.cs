using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Honeymoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());

            double allSum = 0;
            
            double cairo = (numberNights * 500) + 600;
            double paris = (numberNights * 300) + 350;
            double lima = (numberNights * 800) + 850;
            double newYork = (numberNights * 600) + 650;
            double tokyo = (numberNights * 700) + 700;

            if (numberNights >= 1 && numberNights <= 4)
            {
                if (town == "Cairo")
                {
                    allSum = cairo * 0.97;

                }
                else if (town == "New York")
                {
                    allSum = newYork * 0.97;

                }
            }
            else if (numberNights >= 5 && numberNights <= 9)
            {
                if (town == "Cairo")
                {
                    allSum = cairo * 0.95;
                }
                else if (town == "New York")
                {
                    allSum = newYork * 0.95;
                }
                else if (town == "Paris")
                {
                    allSum = paris * 0.93;
                }
            }
            else if (numberNights >= 10 && numberNights <= 24)
            {
                if (town == "Cairo")
                {
                    allSum = cairo * 0.90;

                }
                else if (town == "Paris")
                {
                    allSum = paris * 0.88;

                }
                else if (town == "New York")
                {
                    allSum = newYork * 0.88;

                }
                else if (town == "Tokyo")
                {
                    allSum = tokyo * 0.88;

                }
            }
            else if (numberNights >= 25 && numberNights <= 49)
            {
                if (town == "Tokyo")
                {
                    allSum = tokyo * 0.83;
                }
                else if (town == "Cairo")
                {
                    allSum = cairo * 0.83;
                }
                else if (town == "New York")
                {
                    allSum = newYork * 0.81;
                }
                else if (town == "Lima")
                {
                    allSum = lima * 0.81;

                }
                else if (town == "Paris")
                {
                    allSum = paris * 0.78;

                }
            }
            else if (numberNights >= 50)
            {
                if (town == "Cairo")
                {
                    allSum = cairo * 0.70;
                }
                else if (town == "Paris")
                {
                    allSum = paris * 0.70;
                }
                else if (town == "Lima")
                {
                    lima = lima * 0.70;

                }
                else if (town == "New York")
                {
                    allSum = newYork * 0.70;

                }
                else if (town == "Tokyo")
                {
                    allSum = tokyo * 0.70;

                }
            }

            if (allSum <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - allSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {allSum - budget:F2} leva.");
            }
        }
    }
}
