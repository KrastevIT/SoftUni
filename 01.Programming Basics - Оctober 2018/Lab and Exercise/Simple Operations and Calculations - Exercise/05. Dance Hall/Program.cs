using System;


namespace _05.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthHall = double.Parse(Console.ReadLine());
            double widthHall = double.Parse(Console.ReadLine());
            double sideWardrobe = double.Parse(Console.ReadLine());

            double sizeHall = (lengthHall * 100) * (widthHall * 100);
            double sizeWardrobe = 200 * 200;
            double sizeBench = sizeHall / 10;
            double freeSpace = sizeHall - sizeWardrobe - sizeBench;
            double numberDancers = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(numberDancers));
        }
    }
}
