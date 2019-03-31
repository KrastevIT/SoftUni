using System;


namespace _18._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            int lengthSm = int.Parse(Console.ReadLine());
            int widthSm = int.Parse(Console.ReadLine());
            int heightSm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double v = lengthSm * widthSm * heightSm;
            v = v * 0.001;
            percent = percent * 0.01;

            double result = v * (1 - percent);

            Console.WriteLine($"{result:F3}");

            
            
        }
    }
}
