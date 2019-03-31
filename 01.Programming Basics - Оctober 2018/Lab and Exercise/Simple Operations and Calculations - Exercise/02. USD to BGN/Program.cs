using System;


namespace _02.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;

            Math.Round(bgn, 2);

            Console.WriteLine("{0:F2}", bgn);
        }
    }
}
