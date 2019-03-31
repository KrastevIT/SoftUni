using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            double leftCarSum = 0;
            double rightCarSum = 0;

            for (int i = 0; i < numbers.Count / 2 - 1; i++)
            {
                if (numbers[i] == 0)
                {
                    double zeroIndex = leftCarSum * 0.20;
                    leftCarSum -= zeroIndex;
                }
                else
                {
                    leftCarSum += numbers[i]
                }
            }
            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                //rightCar.Add(numbers[i]);
            }

        }
    }
}
