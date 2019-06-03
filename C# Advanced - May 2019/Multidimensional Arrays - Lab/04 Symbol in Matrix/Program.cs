using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[,] matrix = new string[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inputSymbols = Console.ReadLine();

                var symbol = new List<string>();

                for (int i = 0; i < inputSymbols.Length; i++)
                {
                    symbol.Add(inputSymbols[i].ToString());
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symbol[col];
                }
            }

            string magicSymbol = Console.ReadLine();

            bool isSearch = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == magicSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isSearch = false;
                        return;
                    }
                }
            }

            if (isSearch)
            {
                Console.WriteLine($"{magicSymbol} does not occur in the matrix");
            }
        }
    }
}
