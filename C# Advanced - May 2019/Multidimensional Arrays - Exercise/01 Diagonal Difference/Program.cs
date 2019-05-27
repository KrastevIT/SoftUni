using System;
using System.Linq;

namespace _01_Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            int[,] matrix = new int[input, input];

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int secondaryCount = input - 1;
            int difference = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];
                }

                primaryDiagonal += elements[i];
                secondaryDiagonal += elements[secondaryCount];
                secondaryCount--;

            }

            difference = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(difference);
        }
    }
}
