﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private readonly int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public string Draw()
        {
            var sb = new StringBuilder();

            double rIn = this.radius - 0.4;

            double rOut = this.radius + 0.4;

            for (double y = this.radius; y >= -this.radius; --y)
            {

                for (double x = -this.radius; x < rOut; x += 0.5)
                {

                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
