using System;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 1; row <= n; row++)
            {
                PrintRow(row, n);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                PrintRow(i, n);
            }
        }

        private static void PrintRow(int row, int n)
        {
            int space = n - row;

            Console.Write(new string(' ', space));

            for (int i = 0; i < row; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
