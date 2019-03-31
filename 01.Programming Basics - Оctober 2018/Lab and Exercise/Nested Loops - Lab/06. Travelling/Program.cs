using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while (command != "End")
            {
                double sum = double.Parse(Console.ReadLine());
                double ourSum = 0;
                while (true)
                {
                    double currentSum = double.Parse(Console.ReadLine());
                    ourSum += currentSum;
                    if (ourSum >= sum)
                    {
                        break;
                    }
                }
                Console.WriteLine($"Going to {command}!");
                command = Console.ReadLine();
            }
        }
    }
}
