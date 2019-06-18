using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_The_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());

            var garden = new string[rows][];

            for (var row = 0; row < garden.Length; row++)
            {
                garden[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            var harmedVegetables = 0;
            var lettuce = 0;
            var potatoes = 0;
            var carrots = 0;

            var commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End of Harvest")
            {
                var currentCommand = commands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var action = currentCommand[0];
                var row = int.Parse(currentCommand[1]);
                var col = int.Parse(currentCommand[2]);

                if (action == "Harvest")
                {
                    if (isInside(garden, row, col) && garden[row][col] != " ")
                    {
                        if (garden[row][col] == "L")
                        {
                            lettuce++;
                        }
                        else if (garden[row][col] == "P")
                        {
                            potatoes++;
                        }
                        else if (garden[row][col] == "C")
                        {
                            carrots++;
                        }
                        garden[row][col] = " ";
                    }
                }
                else if (action == "Mole")
                {
                    var direction = currentCommand[3];

                    if (direction == "up")
                    {
                        while (true)
                        {
                            if (!isInside(garden, row, col))
                            {
                                break;
                            }

                            if (isInside(garden, row, col) && garden[row][col] != " ")
                            {
                                garden[row][col] = " ";
                                harmedVegetables++;
                            }
                            row -= 2;
                        }
                    }
                    else if (direction == "down")
                    {
                        while (true)
                        {
                            if (!isInside(garden, row, col))
                            {
                                break;
                            }

                            if (isInside(garden, row, col) && garden[row][col] != " ")
                            {
                                garden[row][col] = " ";
                                harmedVegetables++;
                            }
                            row += 2;
                        }
                    }
                    else if (direction == "left")
                    {
                        while (true)
                        {
                            if (!isInside(garden, row, col))
                            {
                                break;
                            }

                            if (isInside(garden, row, col) && garden[row][col] != " ")
                            {
                                garden[row][col] = " ";
                                harmedVegetables++;
                            }
                            col -= 2;
                        }
                    }
                    else if (direction == "right")
                    {
                        while (true)
                        {
                            if (!isInside(garden, row, col))
                            {
                                break;
                            }

                            if (isInside(garden, row, col) && garden[row][col] != " ")
                            {
                                garden[row][col] = " ";
                                harmedVegetables++;
                            }
                            col += 2;
                        }
                    }
                }

            }

            PrintGarden(garden);
            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");
        }

        private static bool isInside(string[][] garden, int row, int col)
        {
            return row >= 0 && row < garden.Length &&
                col >= 0 && col <= garden[row].Length;
        }

        private static void PrintGarden(string[][] garden)
        {
            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}