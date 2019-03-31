using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            double numRows = double.Parse(Console.ReadLine());
            double numColumns = double.Parse(Console.ReadLine());

            if (projection == "Premiere")
            {
                Console.WriteLine($"{12 * numRows * numColumns:F2} leva");
            }
            else if (projection == "Normal")
            {
                Console.WriteLine($"{7.50 * numRows * numColumns:F2} leva ");
            }
            else if (projection == "Discount")
            {
                Console.WriteLine($"{5 * numRows * numColumns:F2} leva");
            }
        }
    }
}
