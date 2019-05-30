using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var firstElements = new List<int>();
            var secondElements = new List<int>();
            var elements = new List<int>();

            int firstNumber = numbers[0];
            int secondNumber = numbers[1];

            for (int i = 0; i < firstNumber; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                firstElements.Add(inputNumber);
            }

            for (int i = 0; i < secondNumber; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                secondElements.Add(inputNumber);
            }

            foreach (var number in firstElements)
            {
                if (secondElements.Contains(number))
                {
                    if (!elements.Contains(number))
                    {
                        elements.Add(number);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
