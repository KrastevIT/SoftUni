using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int limit = int.Parse(Console.ReadLine());

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "end")
            {
                if (command[0] == "Add")
                {
                    int convertCommand = int.Parse(command[1]);
                    numbers.Add(convertCommand);
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int convertCommand = int.Parse(command[0]);
                        int range = limit - numbers[i];

                        if (range >= convertCommand)
                        {
                            numbers[i] += convertCommand;
                            break;
                        }
                    }
                }


                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
