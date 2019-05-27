using System;
using System.Linq;

namespace _04_Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimension[0];
            int cols = dimension[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                string[] inputOfCommands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (inputOfCommands[0] == "END")
                {
                    break;
                }

                if (inputOfCommands[0] != "swap" || inputOfCommands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                bool isValid = false;

                for (int i = 1; i < inputOfCommands.Length; i++)
                {
                    int number = int.Parse(inputOfCommands[i]);

                    if (i % 2 == 1 && number > rows)
                    {
                        Console.WriteLine("Invalid input!");
                        isValid = true;
                        break;
                    }
                    else if (i % 2 == 1 && number > cols)
                    {
                        Console.WriteLine("Invalid input!");
                        isValid = true;
                        break;
                    }
                }

                if (isValid)
                {
                    continue;
                }

                int row1 = int.Parse(inputOfCommands[1]);
                int col1 = int.Parse(inputOfCommands[2]);
                int row2 = int.Parse(inputOfCommands[3]);
                int col2 = int.Parse(inputOfCommands[4]);

                string firstElement = matrix[row1, col1];
                string secondElement = matrix[row2, col2];

                matrix[row1, col1] = secondElement;
                matrix[row2, col2] = firstElement;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }

                if (inputOfCommands[0] == "END")
                {
                    break;
                }

            }
        }
    }
}
