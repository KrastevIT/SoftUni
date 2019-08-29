using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Reverse_Array
{
    class Program
    {
        static List<int> reserveNumbers = new List<int>();
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join(" ", ReverseArray(numbers, 0)));
        }

        private static List<int> ReverseArray(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                return reserveNumbers;
            }
            else
            {
                ReverseArray(numbers, index + 1);
                reserveNumbers.Add(numbers[index]);
            }

            return reserveNumbers;

        }
    }
}
