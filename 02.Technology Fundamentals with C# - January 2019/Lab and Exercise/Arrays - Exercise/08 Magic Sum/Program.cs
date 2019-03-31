using System;
using System.Linq;

namespace _08_Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int specialNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int k = i; k < numbers.Length-1; k++)
                {
                    int sum = numbers[i] + numbers[k + 1];
                    if (sum == specialNumber)
                    {
                        Console.Write($"{numbers[i]} {numbers[k + 1]}");
                        Console.WriteLine();
                    }
                }

            }
        }
    }
}
