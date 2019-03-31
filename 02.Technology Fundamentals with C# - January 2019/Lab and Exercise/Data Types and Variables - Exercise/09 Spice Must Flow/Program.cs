using System;

namespace _09_Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int updatedYield = yield;
            int totalAmount = 0;
            int days = 0;

            while (updatedYield >= 100)
            {
                totalAmount += updatedYield - 26;
                updatedYield -= 10;
                days++;
            }
            if (days == 0)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine($"{days}");
                Console.WriteLine($"{totalAmount - 26}");
            }
          
        }
    }
}
