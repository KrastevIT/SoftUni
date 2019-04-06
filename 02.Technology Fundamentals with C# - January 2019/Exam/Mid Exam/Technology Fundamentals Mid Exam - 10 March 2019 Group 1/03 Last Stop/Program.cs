using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "Change")
                {
                    int firsNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    if (numbers.Contains(firsNumber))
                    {
                        int index = numbers.IndexOf(firsNumber);
                        numbers.RemoveAt(index);
                        numbers.Insert(index, secondNumber);
                    }
                }
                else if (command[0] == "Hide")
                {
                    int firsNumber = int.Parse(command[1]);

                    if (numbers.Contains(firsNumber))
                    {
                        numbers.Remove(firsNumber);
                    }
                }
                else if (command[0] == "Switch")
                {
                    int firsNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    if (numbers.Contains(firsNumber) && numbers.Contains(secondNumber))
                    {
                        int oneIndex = numbers.IndexOf(firsNumber);
                        int twoIndex = numbers.IndexOf(secondNumber);

                        numbers.RemoveAt(oneIndex);
                        numbers.Insert(oneIndex, secondNumber);

                        numbers.RemoveAt(twoIndex);
                        numbers.Insert(twoIndex, firsNumber);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    if (index < numbers.Count)
                    {
                        numbers.Insert(index + 1,secondNumber);
                    }
                }
                else if (command[0] == "Reverse")
                {
                    numbers.Reverse();
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
