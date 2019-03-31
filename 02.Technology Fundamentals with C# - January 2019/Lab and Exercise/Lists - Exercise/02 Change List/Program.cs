using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
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

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int convertCommand = int.Parse(command[1]);
                    numbers.RemoveAll(x => x== convertCommand);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index,element);
                }

                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
