using System;

namespace _10_Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int countTarget = 0;
            double newN = n;


            while (newN >= m)
            {
                double targetPoked = newN - m;
                newN = targetPoked;
                double testPower = (double)n / 2;

                if (newN == testPower && y > 0)
                {
                    newN = newN / y;
                }
                countTarget++;
            }
            Console.WriteLine(Math.Floor(newN));
            Console.WriteLine(countTarget);
        }
    }
}
