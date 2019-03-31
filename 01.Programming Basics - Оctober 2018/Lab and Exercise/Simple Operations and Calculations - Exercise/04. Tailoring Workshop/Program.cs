using System;


namespace _04.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTables = int.Parse(Console.ReadLine());
            double lengthTables = double.Parse(Console.ReadLine());
            double widthTables = double.Parse(Console.ReadLine());

            double totalAreaТablecloths = numberTables * (lengthTables + 2 * 0.30) * (widthTables + 2 * 0.30);
            double totalAreaCoach = numberTables * (lengthTables / 2) * (lengthTables / 2);

            double usd = totalAreaТablecloths * 7 + totalAreaCoach * 9;
            double bgn = usd * 1.85;

            Console.WriteLine($"{usd:F2} USD");
            Console.WriteLine($"{bgn:F2} BGN");
        }
    }
}
