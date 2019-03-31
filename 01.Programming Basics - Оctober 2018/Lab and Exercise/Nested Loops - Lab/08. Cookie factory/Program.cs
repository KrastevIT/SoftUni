using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            bool hasEggs = false;
            bool hasSugar = false;
            bool hasFlour = false;
            int counter = 0;

            for (int i = 1; i <= count; i++)
            {
                string command = Console.ReadLine();

                while (command != "Bake!")
                {
                    switch (command)
                    {
                        case "eggs":
                            hasEggs = true;
                            break;
                        case "sugar":
                            hasSugar = true;
                            break;
                        case "flour":
                            hasFlour = true;
                            break;
                    }

                    command = Console.ReadLine();
                }
                if (hasEggs && hasFlour && hasSugar)
                {
                     hasEggs = false;
                     hasSugar = false;
                     hasFlour = false;
                    counter++;
                    Console.WriteLine($"Baking batch number {counter}...");
                }
                else
                {
                    i--;
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
            }
        }
    }
}
