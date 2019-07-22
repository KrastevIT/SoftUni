using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double airConditionerConsumption = 1.4;
        public Bus(double fuelQuantity, double litersPerKm, double tankCapacity)
            : base(fuelQuantity, litersPerKm + airConditionerConsumption, tankCapacity)
        {

        }

        public string DriveEmpty(double distance)
        {
            this.LitersPerKm -= airConditionerConsumption;
            return base.Drive(distance);
        }
    }
}
