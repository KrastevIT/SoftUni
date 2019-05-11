using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackOfNumbers = new Stack<int>();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pushElements = input[0];
            int popElemtns = input[1];
            int magicNumber = input[2];

            for (int i = 0; i < pushElements; i++)
            {
                stackOfNumbers.Push(numbers[i]);
            }

            for (int i = 0; i < popElemtns; i++)
            {
                stackOfNumbers.Pop();
            }

            if (stackOfNumbers.Contains(magicNumber))
            {
                Console.WriteLine("true");
            }
            else if (stackOfNumbers.Count > 0)
            {
                Console.WriteLine(stackOfNumbers.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
