using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var number in inputNumbers)
            {
                stack.Push(number);
            }

            string[] inputCommands = Console.ReadLine().ToLower().Split();

            while (inputCommands[0] != "end")
            {
                string commad = inputCommands[0];
                int index = int.Parse(inputCommands[1]);

                if (commad == "add")
                {
                    int value = int.Parse(inputCommands[2]);

                    stack.Push(index);
                    stack.Push(value);

                }
                else if (commad == "remove")
                {
                    if (stack.Count >= index)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                inputCommands = Console.ReadLine().ToLower().Split();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");


        }
    }
}
