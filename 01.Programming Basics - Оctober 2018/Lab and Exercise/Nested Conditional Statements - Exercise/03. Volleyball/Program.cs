using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double result = h + (48 - h) * 3 / 4 + p * 2 / 3;

            if (input == "leap")
            {
                result = (result + (result * 15 / 100));
            }
            Console.WriteLine((int)result);
        }
    }
}
