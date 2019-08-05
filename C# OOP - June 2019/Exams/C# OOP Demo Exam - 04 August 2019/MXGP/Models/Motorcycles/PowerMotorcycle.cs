using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Models.Motorcycles
{
    public class PowerMotorcycle : Motorcycle
    {
        private const double INITIAL_CUBICCENTIMETERS = 450;
        private const int MIN_HORSE_POWER = 70;
        private const int MAX_HORSE_POWER = 100;

        private int horsePower;
        public PowerMotorcycle(string model, int horsePower)
            : base(model, horsePower, INITIAL_CUBICCENTIMETERS)
        {

        }

        public override int HorsePower
        {
            get
            {
                return this.horsePower;
            }
            protected set
            {
                if (value < MIN_HORSE_POWER || value > MAX_HORSE_POWER)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }

                this.horsePower = value;
            }
        }
    }
}
