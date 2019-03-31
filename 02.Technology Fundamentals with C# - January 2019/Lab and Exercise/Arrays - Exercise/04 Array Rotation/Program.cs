using System;
using System.Linq;

namespace _04_Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                   .Split()
                   .Select(int.Parse)
                   .ToArray();

            int[] totalNumber = new int[numbers.Length];
            int counter = 1;
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                totalNumber[numbers.Length - 1] = numbers[0];

                for (int k = 0; k < numbers.Length - 1; k++)
                {
                    totalNumber[numbers.Length - (counter + 1)] = numbers[numbers.Length - counter];
                    counter++;
                }

                numbers = totalNumber;
                totalNumber = new int[numbers.Length];
                counter = 1;
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
