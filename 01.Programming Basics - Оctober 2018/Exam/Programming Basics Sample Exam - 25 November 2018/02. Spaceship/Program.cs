using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double volumeRocket = width * length * height;
            double volumeRoom = (averageHeight + 0.40) * 2 * 2;
            double astronauts = Math.Round(volumeRocket / volumeRoom);

            if (astronauts >= 3 && astronauts <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronauts} astronauts.");
            }
            else if (astronauts < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronauts > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
