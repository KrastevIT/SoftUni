using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Cooking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split('#').ToList();

            int bigSum = 0;
            List<int> qualityOfBread = new List<int>();

            while (command[0] != "Bake It!")
            {
                List<int> numbers = new List<int>();

                for (int i = 0; i < command.Count; i++)
                {
                    int number = int.Parse(command[i]);
                    numbers.Add(number);
                }

                int sumNumbers = numbers.Sum();

                if (sumNumbers > bigSum)
                {
                    bigSum = sumNumbers;
                    qualityOfBread = new List<int>();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        qualityOfBread.Add(numbers[i]);
                    }

                }

                else if (sumNumbers == bigSum)
                {
                    if (numbers.Count < qualityOfBread.Count)
                    {
                        qualityOfBread = new List<int>();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            qualityOfBread.Add(numbers[i]);
                        }
                    }
                }

                command = Console.ReadLine().Split('#').ToList();
            }

            Console.WriteLine($"Best Batch quality: {bigSum}");
            Console.WriteLine(String.Join(" ", qualityOfBread));
        }
    }
}
