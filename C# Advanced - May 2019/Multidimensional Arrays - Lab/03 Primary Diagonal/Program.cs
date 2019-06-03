using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int counter = 0;

            int finalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }

                finalSum += matrix[row, counter++];
            }

            Console.WriteLine(finalSum);
        }
    }
}
