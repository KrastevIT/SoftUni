using System;


namespace _10.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());

            double volume = Math.Round((width * length * height * 0.001), 3);

            double percentage = n * 0.01;

            double litre = volume * (1 - percentage);

            Console.WriteLine("{0:f3}", litre);
        }
    }
}
