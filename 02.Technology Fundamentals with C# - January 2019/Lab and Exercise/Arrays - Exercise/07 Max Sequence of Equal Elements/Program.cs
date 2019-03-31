using System;
using System.Linq;
namespace _07_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] longNumber = null;
            int longestSequence = 0;
            int counter = 1;
            int longestCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length - 1 && numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > longestCounter)
                    {
                        longestSequence = numbers[i];
                        longestCounter = counter;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            longNumber = new int[longestCounter];

            for (int m = 0; m < longNumber.Length; m++)
            {
                longNumber[m] = longestSequence;
            }

            Console.WriteLine(String.Join(" ", longNumber));
        }
    }
}
