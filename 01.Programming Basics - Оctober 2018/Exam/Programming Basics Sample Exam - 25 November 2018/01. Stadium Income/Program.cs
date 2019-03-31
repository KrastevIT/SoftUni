using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Stadium_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Double sectors = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());
            double priceOfTicket = double.Parse(Console.ReadLine());

            double total = capacity * priceOfTicket;
            double placeOfSector = (capacity / sectors) * priceOfTicket;
            double money = (total - (placeOfSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {total:F2} BGN");
            Console.WriteLine($"Money for charity - {money:F2} BGN");
        }
    }
}
