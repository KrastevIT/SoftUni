using System;

namespace _09_Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = -1;

            for (int num = 1; num <= n; num++)
            {
                number += 2;
                Console.WriteLine(number);
                sum += number;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
