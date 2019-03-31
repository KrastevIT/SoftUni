using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sushi_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string name = Console.ReadLine();
            double portions = double.Parse(Console.ReadLine());
            string sumbol = Console.ReadLine();
            bool error = false;

            double priceOrder = 0;

            double sashimi = 0;
            double maki = 0;
            double uramaki = 0;
            double temaki = 0;

            if (name == "Sushi Zone")
            {
                if (sushi == "sashimi")
                {
                    priceOrder = portions * 4.99;
                }
                else if (sushi == "maki")
                {
                    priceOrder = portions * 5.29;
                }
                else if (sushi == "uramaki")
                {
                    priceOrder = portions * 5.99;
                }
                else if (sushi == "temaki")
                {
                    priceOrder = portions * 4.29;
                }
                error = true;
            }
            if (name == "Sushi Time")
            {
                if (sushi == "sashimi")
                {
                    priceOrder = portions * 5.49;
                }
                else if (sushi == "maki")
                {
                    priceOrder = portions * 4.69;
                }
                else if (sushi == "uramaki")
                {
                    priceOrder = portions * 4.49;
                }
                else if (sushi == "temaki")
                {
                    priceOrder = portions * 5.19;
                }
                error = true;
            }
            if (name == "Sushi Bar")
            {
                if (sushi == "sashimi")
                {
                    priceOrder = portions * 5.25;
                }
                else if (sushi == "maki")
                {
                    priceOrder = portions * 5.55;
                }
                else if (sushi == "uramaki")
                {
                    priceOrder = portions * 6.25;
                }
                else if (sushi == "temaki")
                {
                    priceOrder = portions * 4.75;
                }
                error = true;
            }
            if (name == "Asian Pub")
            {
                if (sushi == "sashimi")
                {
                    priceOrder = portions * 4.50;
                }
                else if (sushi == "maki")
                {
                    priceOrder = portions * 4.80;
                }
                else if (sushi == "uramaki")
                {
                    priceOrder = portions * 5.50;
                }
                else if (sushi == "temaki")
                {
                    priceOrder = portions * 5.50;
                }
                error = true;
            }
            if (sumbol == "Y" && error == true)
            {
                double priceDelivery = priceOrder * 0.20;
                double allSum = priceDelivery + priceOrder;
                Console.WriteLine($"Total price: {Math.Ceiling(allSum)} lv.");
            }
            if (sumbol == "N" && error == true)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(priceOrder)} lv.");
            }
            if (error == false)
            {
                Console.WriteLine($"{name} is invalid restaurant!");
            }




        }
    }
}
