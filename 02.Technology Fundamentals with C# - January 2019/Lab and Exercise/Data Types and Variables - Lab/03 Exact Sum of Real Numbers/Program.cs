using System;
using System.Numerics;

namespace _03_Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal numbers = 0;

            for (int i = 0; i < n; i++)
            {
                 numbers += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(numbers);

        }
    }
}
