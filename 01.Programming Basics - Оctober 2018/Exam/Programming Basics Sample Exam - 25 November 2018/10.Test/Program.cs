using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushi = Console.ReadLine();
            string imeRestorant = Console.ReadLine();
            double porcii = double.Parse(Console.ReadLine());
            string sumbol = Console.ReadLine();

            double allSum = 0;

            bool fall = false;

            double sashimi = 0;
            double maki = 0;
            double uramaki = 0;
            double temaki = 0;

            if (imeRestorant == "Sushi Zone")
            {
                fall = true;

                if (sushi == "sashimi")
                {
                    allSum = porcii * 4.99;
                }
                else if (sushi == "maki")
                {
                    allSum = porcii * 5.29;

                }
                else if (sushi == "uramaki")
                {
                    allSum = porcii * 5.99;
                }
                else if (sushi == "temaki")
                {
                    allSum = porcii * 4.29;
                }


            }
            if (imeRestorant == "Sushi Time")
            {
                fall = true;

                if (sushi == "sashimi")
                {
                    allSum = porcii * 5.49;
                }
                else if (sushi == "maki")
                {
                    allSum = porcii * 4.69;

                }
                else if (sushi == "uramaki")
                {
                    allSum = porcii * 4.49;
                }
                else if (sushi == "temaki")
                {
                    allSum = porcii * 5.19;
                }
            }
            if (imeRestorant == "Sushi Bar")
            {
                fall = true;

                if (sushi == "sashimi")
                {
                    allSum = porcii * 5.25;
                }
                else if (sushi == "maki")
                {
                    allSum = porcii * 5.55;

                }
                else if (sushi == "uramaki")
                {
                    allSum = porcii * 6.25;
                }
                else if (sushi == "temaki")
                {
                    allSum = porcii * 4.75;
                }
            }
            if (imeRestorant == "Sushi Pub ")
            {
                fall = true;

                if (sushi == "sashimi")
                {
                    allSum = porcii * 4.50;
                }
                else if (sushi == "maki")
                {
                    allSum = porcii * 4.80;

                }
                else if (sushi == "uramaki")
                {
                    allSum = porcii * 5.50;
                }
                else if (sushi == "temaki")
                {
                    allSum = porcii * 5.50;
                }

            }

            if (sumbol == "Y" && fall != false)
            {
                double SumDostavka = allSum * 0.20;
                double allSumDostavka = SumDostavka + allSum;
                Console.WriteLine($"Total price: {Math.Ceiling(allSumDostavka)} lv.");
            }
            else if (sumbol == "N" && fall != false)
            {
                Console.WriteLine($"Total price: {Math.Ceiling(allSum)} lv.");
            }
            else
            {
                Console.WriteLine($"{imeRestorant} is invalid restaurant");
            }
        }
    }
}