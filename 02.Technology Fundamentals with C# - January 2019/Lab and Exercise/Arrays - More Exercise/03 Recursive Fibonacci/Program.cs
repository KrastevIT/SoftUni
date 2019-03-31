using System;

namespace _03_Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 1;

            for (int i = 1; i < n; i++)
            {
                secondSum = firstSum + secondSum;
                firstSum = secondSum - firstSum;

            }
                Console.WriteLine(secondSum);
        }
    }
}
