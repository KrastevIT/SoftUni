using System;

namespace _06_Connected_Areas_in_Matrix
{
    class Program
    {
        static char[,] matrix;

        static int found = 0;
        static int areaSize = 0;
        static int positonRow = -1;
        static int positionCol = -1;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            matrix = new char[rows, cols];

            InitialMatrix(matrix);
            Connencted(0, 0);
        }

        private static void Connencted(int row, int col)
        {
            if (ValidCoordination(row, col) && FindNumber(row, col))
            {
                positonRow = row;
                positionCol = col;
                areaSize++;
                Connencted(row, col + 1);
            }
            else if (ValidCoordination(row, col))
            {
                if (ValidPath(row, col))
                {
                    matrix[row, col] = 'x';
                    Connencted(row, col + 1);
                    matrix[row, col] = '-';
                }
            }
        }

        private static bool ValidPath(int row, int col)
        {
            return matrix[row, col] == '-';
        }

        private static bool FindNumber(int row, int col)
        {
            return char.IsDigit(matrix[row, col]);
        }

        private static bool ValidCoordination(int row, int col)
        {
            return
                row >= 0 &&
                row < matrix.GetLength(0) &&
                col >= 0 &&
                col < matrix.GetLength(1);
        }

        private static void InitialMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
