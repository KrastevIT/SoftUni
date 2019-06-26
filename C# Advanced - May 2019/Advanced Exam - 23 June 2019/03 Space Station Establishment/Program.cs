using System;
using System.Linq;

namespace _03_Space_Station_Establishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int rowStephen = -1;
            int colStephen = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'S')
                    {
                        rowStephen = row;
                        colStephen = col;
                    }
                }
            }

            int energy = 0;


            while (true)
            {
                string move = Console.ReadLine();

                bool isExit = false;

                matrix[rowStephen, colStephen] = '-';

                if (move == "up")
                {
                    if (rowStephen - 1 >= 0)
                    {
                        rowStephen--;
                    }
                    else
                    {
                        isExit = true;
                    }

                }
                else if (move == "down")
                {
                    if (rowStephen + 1 < matrix.GetLength(0))
                    {
                        rowStephen++;
                    }
                    else
                    {
                        isExit = true;
                    }
                }
                else if (move == "left")
                {
                    if (colStephen - 1 >= 0)
                    {
                        colStephen--;
                    }
                    else
                    {
                        isExit = true;
                    }
                }
                else if (move == "right")
                {
                    if (colStephen + 1 < matrix.GetLength(1))
                    {
                        colStephen++;
                    }
                    else
                    {
                        isExit = true;
                    }
                }

                string currentPosition = matrix[rowStephen, colStephen].ToString();

                bool isStar = int.TryParse(currentPosition, out int number);

                if (isExit)
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    Console.WriteLine($"Star power collected: {energy}");

                    Print(matrix);
                    break;
                }

                if (isStar)
                {
                    energy += number;

                    matrix[rowStephen, colStephen] = 'S';

                }
                else if (currentPosition == "O")
                {
                    int pointRow = -1;
                    int pointCol = -1;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (matrix[row, col] == 'O')
                            {
                                matrix[row, col] = '-';
                                pointRow = row;
                                pointCol = col;
                            }
                        }
                    }
                    matrix[pointRow, pointCol] = 'S';

                    rowStephen = pointRow;
                    colStephen = pointCol;
                }
                else if (currentPosition == "-")
                {
                    matrix[rowStephen, colStephen] = 'S';
                }

                if (energy >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    Console.WriteLine($"Star power collected: {energy}");

                    Print(matrix);
                    break;
                }
            }
        }

        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
