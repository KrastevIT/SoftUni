using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> inputNumbers = Console.ReadLine()
                  .Split()
                  .Select(long.Parse)
                  .ToList();

            long sum = 0;
            while (inputNumbers.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                long element;

                if (index < 0)
                {
                    element = inputNumbers[0];
                    inputNumbers[0] = inputNumbers[inputNumbers.Count - 1];
                }
                else if (index >= inputNumbers.Count)
                {
                    element = inputNumbers[inputNumbers.Count - 1];
                    inputNumbers[inputNumbers.Count - 1] = inputNumbers[0];
                }
                else
                {
                    element = inputNumbers[index];
                    inputNumbers.RemoveAt(index);
                }

                sum += element;
                for (int i = 0; i < inputNumbers.Count; i++)
                {
                    if (inputNumbers[i] <= element)
                    {
                        inputNumbers[i] += element;
                    }
                    else
                    {
                        inputNumbers[i] -= element;
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
