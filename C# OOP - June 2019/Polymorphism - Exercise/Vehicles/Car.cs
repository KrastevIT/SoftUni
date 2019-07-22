using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double airConditionerConsumption = 0.9;
        public Car(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm + airConditionerConsumption, tankCapacity)
        {

        }
    }
}
