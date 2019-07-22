using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicle = new List<Vehicle>();

            for (int i = 1; i <= 3; i++)
            {
                string[] vehicleArgs = Console.ReadLine().Split();

                double fuel = double.Parse(vehicleArgs[1]);
                double liters = double.Parse(vehicleArgs[2]);
                double tankCapacity = double.Parse(vehicleArgs[3]);

                Vehicle currentVehicle = null;

                if (i == 1)
                {
                    currentVehicle = new Car(fuel, liters, tankCapacity);
                }
                else if (i == 2)
                {
                    currentVehicle = new Truck(fuel, liters, tankCapacity);
                }
                else if (i == 3)
                {
                    currentVehicle = new Bus(fuel, liters, tankCapacity);
                }

                vehicle.Add(currentVehicle);
            }

            int line = int.Parse(Console.ReadLine());

            for (int i = 0; i < line; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string command = inputArgs[0];
                string vehicles = inputArgs[1];
                double value = double.Parse(inputArgs[2]);

                var currentVehcle = vehicle.FirstOrDefault(x => x.GetType().Name == vehicles);

                if (command == "Drive")
                {
                    Console.WriteLine(currentVehcle.Drive(value));
                }
                else if (command == "DriveEmpty")
                {
                    Bus currenBus = (Bus)vehicle.FirstOrDefault(x => x.GetType().Name == vehicles);

                    Console.WriteLine(currenBus.DriveEmpty(value));
                }
                else if (command == "Refuel")
                {
                    try
                    {
                        currentVehcle.Refuel(value);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            foreach (var item in vehicle)
            {
                Console.WriteLine(item);
            }
        }
    }
}
