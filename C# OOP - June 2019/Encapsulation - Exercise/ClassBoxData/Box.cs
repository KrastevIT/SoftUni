using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                if (InvalidParameters(value))
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (InvalidParameters(value))
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (InvalidParameters(value))
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            return (Length * Width) * 2 + (Length * Height) * 2 + (Width * Height) * 2;
        }

        public double LateralSurfaceArea()
        {
            return (Length * Height) * 2 + (Width * Height) * 2;
        }

        public double Volume()
        {
            return Length * Width * Height;
        }

        private bool InvalidParameters(double value)
        {
            if (value <= 0)
            {
                return true;
            }

            return false;
        }
    }
}
