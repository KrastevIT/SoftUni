using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputCarsModel = Console.ReadLine().Split().ToArray();
            var queueOfCars = new Queue<string>(inputCarsModel);
            string command;
            var stackOfSuccessfully = new Stack<string>();

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Service")
                {
                    if (queueOfCars.Count > 0)
                    {
                        stackOfSuccessfully.Push(queueOfCars.Peek());
                        Console.WriteLine($"Vehicle {queueOfCars.Dequeue()} got served.");
                    }
                }
                else if (command.Contains("CarInfo"))
                {
                    string[] splitCarsInfo = command.Split('-');
                    string nameOfCar = splitCarsInfo[1];

                    if (queueOfCars.Contains(nameOfCar))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(String.Join(", ", stackOfSuccessfully));
                }
            }

            if (queueOfCars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {String.Join(", ", queueOfCars)}");
            }
            Console.WriteLine($"Served vehicles: {String.Join(", ", stackOfSuccessfully)}");
        }
    }
}
