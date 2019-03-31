using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fan_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budger = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "hoodie":
                        sum += 30;
                        break;
                    case "keychain":
                        sum += 4;
                        break;
                    case "T-shirt":
                        sum += 20;
                        break;
                    case "flag":
                        sum += 15;
                        break;
                    case "sticker":
                        sum += 1;
                        break;
                }
            }
            if (budger >= sum)
            {
                Console.WriteLine($"You bought {n} items and left with {budger - sum} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budger} more lv.");
            }
        }
    }
}
