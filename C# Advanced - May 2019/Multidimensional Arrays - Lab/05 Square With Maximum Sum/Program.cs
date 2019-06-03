using System;
using System.Linq;

namespace _05_Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int finalSum = int.MinValue;
            int indexRow = 0;
            int indexCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentRow = matrix[row, col] + matrix[row, col + 1];
                    int currentCol = matrix[row + 1, col] + matrix[row + 1, col + 1];
                    int sumOfRowAndCol = currentRow + currentCol;

                    if (sumOfRowAndCol > finalSum)
                    {
                        finalSum = sumOfRowAndCol;

                        indexRow = row;
                        indexCol = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[indexRow, indexCol]} {matrix[indexRow, indexCol + 1]}");
            Console.WriteLine($"{matrix[indexRow + 1, indexCol]} { matrix[indexRow + 1, indexCol + 1]}");
            Console.WriteLine(finalSum);
        }
    }
}
