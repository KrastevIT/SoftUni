using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wedding_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double amountWater = double.Parse(Console.ReadLine());
            double amountWine = double.Parse(Console.ReadLine());
            double amountChampagne = double.Parse(Console.ReadLine());
            double amountWiskey = double.Parse(Console.ReadLine());

            double priceChampagne = priceWhiskey * 0.5;
            double priceWine = priceChampagne * 0.4;
            double priceWater = priceChampagne * 0.1;
            double sumChampagne = amountChampagne * priceChampagne;
            double sumWine = amountWine * priceWine;
            double sumWater = amountWater * priceWater;
            double sumWhiskey = amountWiskey * priceWhiskey;
            double allPrise = (sumChampagne + sumWine + sumWater + sumWhiskey);
            Console.WriteLine($"{allPrise:F2}");

        }
    }
}
