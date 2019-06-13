using System;
using System.Collections.Generic;

namespace _10_Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int passedCarsCount = 0;

            bool carWasHit = false;

            var command = Console.ReadLine();

            while (command != "END")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }

                else
                {
                    int currentGreenLight = greenLight;

                    while (cars.Count > 0 && currentGreenLight > 0)
                    {
                        var carLenght = cars.Peek().Length;

                        if (carLenght <= currentGreenLight)
                        {
                            cars.Dequeue();
                            currentGreenLight -= carLenght;
                            passedCarsCount++;
                        }

                        else if (carLenght > currentGreenLight && currentGreenLight > 0)
                        {
                            int currentFreeLight = freeWindow;

                            if (carLenght > currentGreenLight + currentFreeLight)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{cars.Peek()} was hit at {cars.Peek()[currentGreenLight + currentFreeLight]}.");

                                carWasHit = true;
                            }

                            else
                            {
                                cars.Dequeue();
                                passedCarsCount++;
                            }

                            currentGreenLight = 0;
                        }

                    }
                }

                if (carWasHit)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (!carWasHit)
            {
                Console.WriteLine($"Everyone is safe.");
                Console.WriteLine($"{passedCarsCount} total cars passed the crossroads.");
            }
        }
    }
    
}
