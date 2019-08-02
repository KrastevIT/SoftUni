using System;
using System.Linq;

namespace _01_RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Sum(numbers, 0));
        }

        private static int Sum(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }

            var currentSum = numbers[index];

            var nextSum = Sum(numbers, ++index);

            var result = currentSum + nextSum;

            return result;
        }
    }
}
