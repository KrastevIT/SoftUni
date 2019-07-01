using System;

namespace HotelReservation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            PriceCalculator price = new PriceCalculator(input);

            Console.WriteLine(price.GetTotalPrice().ToString("F2"));

        }
    }
}
