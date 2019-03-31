using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Array_Manipulator
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
            List<string> totalResult = new List<string>();

            while (command[0] != "end")
            {
                string leftCommand = command[0];
                string rightCommand = command[1];

                if (leftCommand == "exchange")
                {
                    int index = int.Parse(rightCommand);

                    if (index < numbers.Count)
                    {
                        List<int> result = new List<int>();

                        for (int i = 0; i <= index; i++)
                        {
                            result.Add(numbers[i]);
                        }
                        for (int i = 0; i <= index; i++)
                        {
                            numbers.RemoveAt(0);
                            numbers.Add(result[i]);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }




                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(", ",numbers));



        }
    }
}
