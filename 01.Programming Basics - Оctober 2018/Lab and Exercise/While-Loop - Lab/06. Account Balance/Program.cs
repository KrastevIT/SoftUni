using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int couter = int.Parse(Console.ReadLine());
            int index = 1;
            double total = 0;

            while (index <= couter)
            {
                double sum = double.Parse(Console.ReadLine());
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                total += sum;
                Console.WriteLine($"Increase: {sum:F2}");
                index++;
            }
            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
