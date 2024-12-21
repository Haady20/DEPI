using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public static class Utility
    {
        public static double CalculatePerimeter(double Height, double Width)
        {
            return (Width + Height) * 2;
        }
        public static double CelsiusToFahrenheit(double temp)
        {
            return (temp * 9 / 5) + 32;
        }

        public static double FahrenheitToCelsius(double temp)
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
