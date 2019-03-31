using System;
using System.Linq;

namespace _03_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] leftNumber = new int[n];
            int[] rightNumber = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] number = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    leftNumber[i] = number[0];
                    rightNumber[i] = number[1];
                }
                else
                {
                    leftNumber[i] = number[1];
                    rightNumber[i] = number[0];
                }
            }
            Console.WriteLine(String.Join(" ", leftNumber));
            Console.WriteLine(String.Join(" ", rightNumber));
        }
    }
}
