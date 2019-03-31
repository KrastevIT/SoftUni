using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double min = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
