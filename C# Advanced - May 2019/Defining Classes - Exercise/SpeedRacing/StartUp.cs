using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < countOfCars; i++)
            {
                string[] inputCars = Console.ReadLine().Split();

                string carName = inputCars[0];
                double fuelAmount = int.Parse(inputCars[1]);
                double fuelConsumptionForOneKm = double.Parse(inputCars[2]);

                Car car = new Car(carName, fuelAmount, fuelConsumptionForOneKm);

                cars.Add(car);
            }

            string inputCommands = Console.ReadLine();

            while (inputCommands != "End")
            {
                string[] commands = inputCommands.Split();

                string carName = commands[1];
                double distance = double.Parse(commands[2]);

                Car car = cars.FirstOrDefault(c => c.Model == carName);
                car.Drive(distance);

                inputCommands = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
