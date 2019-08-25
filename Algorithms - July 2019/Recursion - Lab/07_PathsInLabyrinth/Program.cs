using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PathsInLabyrinth
{
    class Program
    {
        static char[,] labyrinth;
        static List<char> path = new List<char>();

        static void Main(string[] args)
        {
            int rowls = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            ReadLabyrinth(rowls, cols);

            FindPaths(0, 0, 'S');
        }

        private static void FindPaths(int row, int col, char direction)
        {
            if (OutsideLabyrinth(row, col))
            {
                return;
            }

            path.Add(direction);

            if (labyrinth[row, col] == 'e')
            {
                Console.WriteLine(string.Join("", path.Skip(1)));
            }
            else if (IsFree(row, col))
            {
                labyrinth[row, col] = 'x';

                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row - 1, col, 'U');

                labyrinth[row, col] = '-';
            }

            path.RemoveAt(path.Count - 1);

        }

        private static bool IsFree(int row, int col)
        {
            return labyrinth[row, col] == '-';
        }

        private static bool OutsideLabyrinth(int row, int col)
        {
            return row >= labyrinth.GetLength(0) ||
                row < 0 ||
                col >= labyrinth.GetLength(1) ||
                col < 0;
        }

        private static void ReadLabyrinth(int rowls, int cols)
        {
            labyrinth = new char[rowls, cols];

            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                string lab = Console.ReadLine();

                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    labyrinth[row, col] = lab[col];
                }
            }
        }

    }
}
