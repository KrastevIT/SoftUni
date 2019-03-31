using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }

        
    }
}
