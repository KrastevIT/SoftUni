using System;

namespace _07_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int totalLiters = 0;

            for (int i = 0; i < input; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                totalLiters += liters;

                if (totalLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= liters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
