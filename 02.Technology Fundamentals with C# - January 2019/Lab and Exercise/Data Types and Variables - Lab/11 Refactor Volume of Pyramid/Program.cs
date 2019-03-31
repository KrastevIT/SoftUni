using System;

namespace _11_Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double volume = length * width * heigth;

            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume / 3:F2}");
        }
    }
}
