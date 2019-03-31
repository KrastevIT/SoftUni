using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) >= 0 && int.Parse(command[2]) < numbers.Count)
                    {
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < numbers.Count)
                    {
                        numbers.RemoveAt(int.Parse(command[1]));

                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        int count = int.Parse(command[2]);

                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (command[1] == "right")
                    {
                        int count = int.Parse(command[2]);

                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }



                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
