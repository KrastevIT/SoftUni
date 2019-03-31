using System;

namespace _05_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    CoffeePrintPrice(quantity);
                    break;
                case "water":
                    WaterPrintPrice(quantity);
                    break;
                case "coke":
                    CokePrintPrice(quantity);
                    break;
                case "snacks":
                    SnacksPrintPrice(quantity);
                    break;
            }
        }

        static void CoffeePrintPrice(double price)
        {
            Console.WriteLine($"{price * 1.50:F2}");
        }

        static void WaterPrintPrice(double price)
        {
            Console.WriteLine($"{price * 1.00:F2}");
        }

        static void CokePrintPrice(double price)
        {
            Console.WriteLine($"{price * 1.40:F2}");
        }

        static void SnacksPrintPrice(double price)
        {
            Console.WriteLine($"{price * 2.00:F2}");
        }
    }
}
