using System;

namespace _04_Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintLeftNumber(input);
            PrintRightNumber(input);
        }

        static void PrintLeftNumber(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintRightNumber(int num)
        {
            for (int row = num - 1; row >= 1; row--)
            {
                for (int col = 1; col < row + 1; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
