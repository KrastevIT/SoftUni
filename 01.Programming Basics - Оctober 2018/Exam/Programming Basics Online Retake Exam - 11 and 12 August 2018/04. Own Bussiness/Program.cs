using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Own_Bussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double firstMeters = width * length * height;
            double secounMeters = 0;


            while (command != "Done")
            {
                int number = int.Parse(command);
                secounMeters += number;

                if (firstMeters < secounMeters)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(firstMeters - secounMeters)} Cubic meters more.");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{firstMeters - secounMeters} Left space.");
        
        }
    }
}
