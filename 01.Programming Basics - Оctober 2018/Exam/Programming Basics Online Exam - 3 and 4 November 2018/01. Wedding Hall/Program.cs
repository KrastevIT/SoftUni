using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wedding_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double side = double.Parse(Console.ReadLine());

            double sizeHall = length * width;
            double sizeBar = side * side;
            double sizeDance = sizeHall * 0.19;
            double freeSpace = sizeHall - sizeBar - sizeDance;
            double countsGuests = freeSpace / 3.2;
            Console.WriteLine(Math.Ceiling(countsGuests));

        }
    }
}
