using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Vehicle
    {
        private double fuelQuantity;
        public Vehicle(double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            LitersPerKm = litersPerKm;
        }
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double LitersPerKm { get; protected set; }

        public double TankCapacity { get; private set; }

        public string Drive(double distance)
        {
            double needFuel = distance * LitersPerKm;

            if (needFuel <= FuelQuantity)
            {
                FuelQuantity -= needFuel;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            double currenLiters = this.FuelQuantity + liters;

            if (currenLiters > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
        }
    }
}
