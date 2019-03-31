using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            double visochina = 5364;
            double dni = 1;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(visochina);
                    return;
                }
                if (dni >= 5)
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(visochina);
                    return;

                }

                if (command == "Yes")
                {

                    dni++;
                }

                double number = double.Parse(Console.ReadLine());

                visochina += number;

                if (visochina >= 8848)
                {
                    Console.WriteLine($"Goal reached for {dni} days!");
                    return;
                }


            }
        }
    }
}
