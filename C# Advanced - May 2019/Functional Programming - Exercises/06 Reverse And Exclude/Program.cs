using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int divisible = int.Parse(Console.ReadLine());

            var listOfNumbers = new List<int>();

            Func<int, int, bool> isFilter = (number, param) => number % param == 0;

            foreach (var currentNumber in inputNumbers)
            {
                if (!isFilter(currentNumber, divisible))
                {
                    listOfNumbers.Add(currentNumber);
                }
            }

             listOfNumbers.Reverse();

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}
