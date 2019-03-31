using System;


namespace _07.Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityBrandy = double.Parse(Console.ReadLine());
            double quantityWhiskey = double.Parse(Console.ReadLine());

            double priceBrandy = priceWhiskey / 2;
            double priceWine = priceBrandy - (0.4 * priceBrandy);
            double priceBeer = priceBrandy - (0.8 * priceBrandy);

            double sumBrandy = quantityBrandy * priceBrandy;
            double sumWine = quantityWine * priceWine;
            double sumBeer = quantityBeer * priceBeer;
            double sumWhiskey = quantityWhiskey * priceWhiskey;

            double obshtaSuma = sumBrandy + sumWine + sumBeer + sumWhiskey;
            Console.WriteLine($"{obshtaSuma:F2}");
        }
    }
}
