using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int countOfSovenir = int.Parse(Console.ReadLine());
            bool isValid = false;
            double finallySum = 0;

            if (country == "Argentina")
            {
                switch (souvenir)
                {
                    case "flags":
                        isValid = true;
                        finallySum += countOfSovenir * 3.25;
                        break;
                    case "caps":
                        isValid = true;
                        finallySum += countOfSovenir * 7.20;
                        break;
                    case "posters":
                        isValid = true;
                        finallySum += countOfSovenir * 5.10;
                        break;
                    case "stickers":
                        isValid = true;
                        finallySum += countOfSovenir * 1.25;
                        break;
                }

            }
            else if (country == "Brazil")
            {
                switch (souvenir)
                {
                    case "flags":
                        isValid = true;
                        finallySum += countOfSovenir * 4.20;
                        break;
                    case "caps":
                        isValid = true;
                        finallySum += countOfSovenir * 8.50;
                        break;
                    case "posters":
                        isValid = true;
                        finallySum += countOfSovenir * 5.35;
                        break;
                    case "stickers":
                        isValid = true;
                        finallySum += countOfSovenir * 1.20;
                        break;
                }

            }
            else if (country == "Croatia")
            {
                switch (souvenir)
                {
                    case "flags":
                        isValid = true;
                        finallySum += countOfSovenir * 2.75;
                        break;
                    case "caps":
                        isValid = true;
                        finallySum += countOfSovenir * 6.90;
                        break;
                    case "posters":
                        isValid = true;
                        finallySum += countOfSovenir * 4.95;
                        break;
                    case "stickers":
                        isValid = true;
                        finallySum += countOfSovenir * 1.10;
                        break;
                }
    
            }
            else if (country == "Denmark")
            {
                switch (souvenir)
                {
                    case "flags":
                        isValid = true;
                        finallySum += countOfSovenir * 3.10;
                        break;
                    case "caps":
                        isValid = true;
                        finallySum += countOfSovenir * 6.50;
                        break;
                    case "posters":
                        isValid = true;
                        finallySum += countOfSovenir * 4.80;
                        break;
                    case "stickers":
                        isValid = true;
                        finallySum += countOfSovenir * 0.90;
                        break;
                }

            }
            else
            {
                Console.WriteLine("Invalid country!");
                return;
            }

            if (isValid)
            {
                Console.WriteLine($"Pepi bought {countOfSovenir} {souvenir} of {country} for {finallySum:F2} lv.");
            }
            else
            {
                Console.WriteLine("Invalid stock!");
            }
        }
    }
}
