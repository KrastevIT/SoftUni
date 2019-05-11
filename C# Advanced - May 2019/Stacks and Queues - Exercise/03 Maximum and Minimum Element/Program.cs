using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stack<int>();

            int operationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < operationsCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int command = input[0];

                if (command == 1)
                {
                    int currentNumber = input[1];
                    numbers.Push(currentNumber);
                }
                else if (command == 2)
                {
                    if (numbers.Count > 0)
                    {
                        numbers.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (command == 4)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
