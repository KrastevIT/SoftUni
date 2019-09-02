using System;
using System.Linq;

namespace _01_Sorting
{
    class Program
    {
        static int[] numbers;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            numbers = new int[input.Length];
            numbers = input;

            Sort(numbers, 0, input.Length - 1);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Sort(int[] numbers, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            int middleIndex = (startIndex + endIndex) / 2;

            Sort(numbers, startIndex, middleIndex);
            Sort(numbers, middleIndex + 1, endIndex);

            Merge(numbers, startIndex, middleIndex, endIndex);
        }

        private static void Merge(int[] numbers, int startIndex, int middleIndex, int endIndex)
        {
            if (middleIndex < 0
                || middleIndex + 1 >= numbers.Length
                || numbers[middleIndex] <= numbers[middleIndex + 1])
            {
                return;
            }

            int[] helperArr = new int[numbers.Length];

            for (int i = startIndex; i <= endIndex; i++)
            {
                helperArr[i] = numbers[i];
            }

            int leftIndex = startIndex;
            int rightIndex = middleIndex + 1;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (leftIndex > middleIndex)
                {
                    numbers[i] = helperArr[rightIndex++];
                }
                else if (rightIndex > endIndex)
                {
                    numbers[i] = helperArr[leftIndex++];
                }
                else if (helperArr[leftIndex] <= helperArr[rightIndex])
                {
                    numbers[i] = helperArr[leftIndex++];
                }
                else
                {
                    numbers[i] = helperArr[rightIndex++];
                }
            }
        }
    }
}
