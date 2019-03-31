using System;

namespace _06_Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAreaOfTriangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        }

        static void PrintAreaOfTriangle(int width, int height)
        {
            Console.WriteLine(width * height);
        }
    }
}
