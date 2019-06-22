using System;
using System.Linq;

namespace _02_Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            int rowFirst = -1;
            int colFirst = -1;
            int rowSecond = -1;
            int colSecound = -1;

            for (int row = 0; row < matrix.Length; row++)
            {
                char[] inputSymbols = Console.ReadLine().ToArray();

                matrix[row] = new char[inputSymbols.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = inputSymbols[col];

                    if (inputSymbols[col] == 'f')
                    {
                        rowFirst = row;
                        colFirst = col;
                    }
                    else if (inputSymbols[col] == 's')
                    {
                        rowSecond = row;
                        colSecound = col;
                    }
                }
            }

            while (true)
            {
                string[] inputCommands = Console.ReadLine().Split();

                string firstPlayer = inputCommands[0];
                string secondPlayer = inputCommands[1];

                if (firstPlayer == "up")
                {
                    if (rowFirst - 1 >= 0)
                    {
                        rowFirst--;
                    }
                    else
                    {
                        rowFirst = matrix.Length - 1;
                    }

                }
                else if (firstPlayer == "down")
                {
                    if (rowFirst + 1 < matrix.Length)
                    {
                        rowFirst++;
                    }
                    else
                    {
                        rowFirst = 0;
                    }
                }
                else if (firstPlayer == "left")
                {
                    if (colFirst - 1 >= 0)
                    {
                        colFirst--;
                    }
                    else
                    {
                        colFirst = matrix[rowFirst].Length - 1;
                    }
                }
                else if (firstPlayer == "right")
                {
                    if (colFirst + 1 < matrix[rowFirst].Length)
                    {
                        colFirst++;
                    }
                    else
                    {
                        colFirst = 0;
                    }
                }

                if (secondPlayer == "up")
                {
                    if (rowSecond - 1 >= 0)
                    {
                        rowSecond--;
                    }
                    else
                    {
                        rowSecond = matrix.Length - 1;
                    }
                }
                else if (secondPlayer == "down")
                {
                    if (rowSecond + 1 < matrix.Length)
                    {
                        rowSecond++;
                    }
                    else
                    {
                        rowSecond = 0;
                    }
                }
                else if (secondPlayer == "left")
                {
                    if (colSecound - 1 >= 0)
                    {
                        colSecound--;
                    }
                    else
                    {
                        colSecound = matrix[rowSecond].Length - 1;
                    }
                }
                else if (secondPlayer == "right")
                {
                    if (colSecound + 1 < matrix[rowSecond].Length)
                    {
                        colSecound++;
                    }
                    else
                    {
                        colSecound = 0;
                    }
                }

                bool isValid = false;

                if (matrix[rowFirst][colFirst] == '*')
                {
                    matrix[rowFirst][colFirst] = 'f';

                    isValid = true;
                }

                if (matrix[rowSecond][colSecound] == '*' && isValid)
                {
                    matrix[rowSecond][colSecound] = 's';
                }


                if (matrix[rowFirst][colFirst] == 's')
                {
                    matrix[rowFirst][colFirst] = 'x';
                    break;
                }
                else if (matrix[rowSecond][colSecound] == 'f')
                {
                    matrix[rowSecond][colSecound] = 'x';
                    break;
                }



            }

            Print(matrix);
        }

        private static void Print(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
        }
    }
}
