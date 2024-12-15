using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSeven
{
    public class Rectanglee : Shape
    {
       public double height,width;
        public Rectanglee(double _height, double _width)
        {
            height = _height;
            width = _width;
        }
        public override double CalculateArea()
        {
            return height * width;
        }
        public override void Draw()
        {
            Console.WriteLine($"Rectangle Width is: '{width}', Rectangle Height is: '{height}'.");
        }
    }
}
