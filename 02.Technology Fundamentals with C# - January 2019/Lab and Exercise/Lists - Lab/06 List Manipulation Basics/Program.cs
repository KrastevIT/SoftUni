using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_List_Manipulation_Basics
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

            while (command[0] != "end")
            {
                int convertCommand = int.Parse(command[1]);

                if (command[0] == "Add")
                {
                    numbers.Add(convertCommand);
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(convertCommand);
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(convertCommand);
                }
                else if (command[0] == "Insert")
                {
                    int indexCommand = int.Parse(command[2]);
                    numbers.Insert(indexCommand, convertCommand);
                }


                command = Console.ReadLine()
                    .Split()
                    .ToList();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
