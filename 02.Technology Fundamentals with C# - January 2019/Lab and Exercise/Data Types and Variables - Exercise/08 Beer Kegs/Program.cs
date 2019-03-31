using System;

namespace _08_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string bigKeg = String.Empty;
            double biggestVolume = 0;

            for (int i = 0; i < input; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double calculation = Math.PI * radius * radius * height;

                if (calculation > biggestVolume)
                {
                    biggestVolume = calculation;
                    bigKeg = model;
                }
            }
            Console.WriteLine(bigKeg);
        }
    }
}
