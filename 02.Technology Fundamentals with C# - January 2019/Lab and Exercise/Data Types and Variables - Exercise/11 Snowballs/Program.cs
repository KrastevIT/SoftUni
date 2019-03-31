using System;
using System.Numerics;

namespace _11_Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int bigSnowballSnow = 0;
            int bigSnowballTime = 0;
            int bigSnowballQuality = 0;

            int snowballValue = 0;
            BigInteger qualitySum = 0;

            BigInteger greaterValue = 0;

            for (int i = 0; i < input; i++)
            {
               int snowballSnow = int.Parse(Console.ReadLine());
               int snowballTime = int.Parse(Console.ReadLine());
               int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = snowballSnow / snowballTime;
                qualitySum = BigInteger.Pow(snowballValue, snowballQuality);

                if (qualitySum > greaterValue)
                {
                    greaterValue = qualitySum;
                    bigSnowballSnow = snowballSnow;
                    bigSnowballTime = snowballTime;
                    bigSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bigSnowballSnow} : {bigSnowballTime} = {greaterValue} ({bigSnowballQuality})");
        }
    }
}
