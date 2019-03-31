using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> leftNumbers = new List<int>();
            List<int> finalNumbers = new List<int>();

            int range = numbers.Count / 4;

            for (int i = range - 1; i >= 0; i--)
            {
                leftNumbers.Add(numbers[i]);
            }
            for (int i = numbers.Count - 1; i > (numbers.Count - 1) - range; i--)
            {
                leftNumbers.Add(numbers[i]);
            }

            for (int i = 0; i < range; i++)
            {
                numbers.RemoveAt(0);
            }

            int lengthNumbers = numbers.Count;

            for (int i = lengthNumbers - 1; i > (lengthNumbers - 1) - range; i--)
            {
                numbers.RemoveAt(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                finalNumbers.Add(leftNumbers[i] + numbers[i]);
            }
            Console.WriteLine(String.Join(" ", finalNumbers));


        }
    }
}
