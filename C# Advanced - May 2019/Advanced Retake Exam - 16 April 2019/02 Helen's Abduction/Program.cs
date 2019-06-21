using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_Helen_s_Abduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int rowsCount = int.Parse(Console.ReadLine());

            char[][] field = new char[rowsCount][];

            int parisRow = 0;
            int parisCol = 0;

            for (int row = 0; row < field.Length; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                field[row] = currentRow;
            }

            bool found = false;

            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    char symbol = field[row][col];

                    if (symbol == 'P')
                    {
                        parisRow = row;
                        parisCol = col;

                        found = true;

                        break;

                    }
                }

                if (found)
                {
                    break;
                }
            }

            bool successfully = false;

            while (energy > 0)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string moveParis = input[0];
                int spawnsRow = int.Parse(input[1]);
                int spawnsCol = int.Parse(input[2]);

                field[spawnsRow][spawnsCol] = 'S';

                field[parisRow][parisCol] = '-';

                if (moveParis == "up")
                {
                    if (parisRow - 1 >= 0)
                    {
                        parisRow--;
                    }
                }
                else if (moveParis == "down")
                {
                    if (parisRow + 1 < field.Length)
                    {
                        parisRow++;
                    }
                }
                else if (moveParis == "left")
                {
                    if (parisCol - 1 >= 0)
                    {
                        parisCol--;
                    }
                }
                else if (moveParis == "right")
                {
                    if (parisCol + 1 < field[parisRow].Length)
                    {
                        parisCol++;
                    }
                }

                energy--;

                if (field[parisRow][parisCol] == 'S')
                {
                    energy -= 2;

                    field[parisRow][parisCol] = 'P';
                }
                else if (field[parisRow][parisCol] == 'H')
                {
                    field[parisRow][parisCol] = '-';

                    successfully = true;

                    break;
                }
                else if (field[parisRow][parisCol] == '-')
                {
                    field[parisRow][parisCol] = 'P';
                }

                if (energy <= 0)
                {
                    field[parisRow][parisCol] = 'X';

                    break;
                }
            }

            if (successfully)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }

            foreach (var row in field)
            {
                Console.WriteLine(row);
            }
        }
    }
}


