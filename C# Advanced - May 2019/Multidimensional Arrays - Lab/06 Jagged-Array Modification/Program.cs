using System;
using System.Linq;

namespace _06_Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNumbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                string command = input[0];

                int indexOfRow = int.Parse(input[1]);
                int indexOfCol = int.Parse(input[2]);
                int indexOfValue = int.Parse(input[3]);

                if (command == "Add" &&
                    indexOfRow < matrix.GetLength(0) &&
                    indexOfCol < matrix.GetLength(1) &&
                    indexOfRow >= 0 &&
                    indexOfCol >= 0)
                {
                    matrix[indexOfRow, indexOfCol] += indexOfValue;
                }
                else if (command == "Subtract" &&
                    indexOfRow < matrix.GetLength(0) &&
                    indexOfCol < matrix.GetLength(1) &&
                    indexOfRow >= 0 &&
                    indexOfCol >= 0)
                {
                    matrix[indexOfRow, indexOfCol] -= indexOfValue;
                }
                else
                {
                    Console.WriteLine($"Invalid coordinates");
                }

                input = Console.ReadLine().Split();
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
