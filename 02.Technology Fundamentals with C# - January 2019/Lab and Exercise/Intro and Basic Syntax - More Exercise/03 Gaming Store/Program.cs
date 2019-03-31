using System;

namespace _03_Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string games = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            bool testGame = false;

            while (games != "Game Time")
            {
                switch (games)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        testGame = true;
                        Console.WriteLine("Not Found");
                        break;
                }
                if (buget < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                if (buget >= price && testGame == false)
                {
                    Console.WriteLine($"Bought {games}");
                    buget -= price;
                    totalPrice += price;
                }

                if (buget == 0 && testGame == false)
                {
                    Console.WriteLine("Out of money!");
                }
                games = Console.ReadLine();
                testGame = false;
            }

            if (buget >= 0)
            {
                Console.WriteLine($"Total spent: ${totalPrice:F2}. Remaining: ${buget:F2}");
            }
        }
    }
}
