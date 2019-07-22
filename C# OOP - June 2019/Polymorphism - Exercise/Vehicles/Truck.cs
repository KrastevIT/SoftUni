using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;
        private const double wastedFuel = 0.05;

        public Truck(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm + airConditionerConsumption, tankCapacity)
        {

        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            FuelQuantity -= liters * wastedFuel;
        }
    }
}
