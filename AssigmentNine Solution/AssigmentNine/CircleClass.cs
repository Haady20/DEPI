﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
        public override bool Equals(object obj)
        {
            if (obj is CircleClass other)
            {
                return Radius == other.Radius && Color == other.Color;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Radius, Color);
        }
    }
}
