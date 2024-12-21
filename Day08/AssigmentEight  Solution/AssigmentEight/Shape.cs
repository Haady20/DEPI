using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public abstract class Shape
    {
        public double X;
        public double Y;
        public abstract string GetArea();
        public string Display()
        {
            if (X != 0 && Y != 0)
            {   
                return $"Width is {X}, Height is {Y}.";
            }
            else
            {
                return $"Radius is: {X}.";
            }
        }
    }
}
