using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<string> command = Console.ReadLine()
                .Split()
                .ToList();

            bool test = false;

            while (command[0] != "end")
            {

                if (command[0] == "Add")
                {
                    int convertCommand = int.Parse(command[1]);
                    numbers.Add(convertCommand);
                    test = true;
                }
                else if (command[0] == "Remove")
                {
                    int convertCommand = int.Parse(command[1]);
                    numbers.Remove(convertCommand);
                    test = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    int convertCommand = int.Parse(command[1]);
                    numbers.RemoveAt(convertCommand);
                    test = true;
                }
                else if (command[0] == "Insert")
                {
                    int convertCommand = int.Parse(command[1]);
                    int indexCommand = int.Parse(command[2]);
                    numbers.Insert(indexCommand, convertCommand);
                    test = true;
                }
                else if (command[0] == "Contains")
                {
                    int convertCommand = int.Parse(command[1]);

                    if (numbers.Contains(convertCommand))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
                    Console.WriteLine(String.Join(" ", evenNumbers));
                }
                else if (command[0] == "PrintOdd")
                {
                    var oddNumbers = numbers.Where(x => x % 2 == 1).ToList();
                    Console.WriteLine(String.Join(" ", oddNumbers));
                }
                else if (command[0] == "GetSum")
                {
                    int getSum = numbers.Sum();
                    Console.WriteLine(getSum);
                }
                else if (command[0] == "Filter")
                {
                    string takeCommand = command[1];
                    int takeDigit = int.Parse(command[2]);
                    List<int> finalNumbers = new List<int>();

                    if (takeCommand == "<")
                    {
                        finalNumbers = numbers.Where(x => x < takeDigit).ToList();
                    }
                    else if (takeCommand == ">")
                    {
                        finalNumbers = numbers.Where(x => x > takeDigit).ToList();
                    }
                    else if (takeCommand == ">=")
                    {
                        finalNumbers = numbers.Where(x => x >= takeDigit).ToList();
                    }
                    else if (takeCommand == "<=")
                    {
                        finalNumbers = numbers.Where(x => x <= takeDigit).ToList();
                    }

                    Console.WriteLine(String.Join(" ", finalNumbers));
                }

                command = Console.ReadLine()
                    .Split()
                    .ToList();
            }

            if (test)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
