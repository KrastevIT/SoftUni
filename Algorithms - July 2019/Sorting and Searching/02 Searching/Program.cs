using System;
using System.Linq;

namespace _02_Searching
{
    class Program
    {
        static int magicNumber;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            magicNumber = int.Parse(Console.ReadLine());

            int result = BinarySearch(input, 0, input.Length - 1);

            Console.WriteLine(result);
        }

        private static int BinarySearch(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return -1;
            }

            int midIndex = (startIndex + endIndex) / 2;

            if (arr[midIndex] == magicNumber)
            {
                return midIndex;
            }

            if (arr[midIndex] > magicNumber)
            {
                return BinarySearch(arr, startIndex, midIndex);
            }
            else
            {
                return BinarySearch(arr, midIndex + 1, endIndex);
            }
        }
    }
}
