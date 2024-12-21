using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public class Rectangle : Shape
    {
        public Rectangle(double _Width, double _Height){
            X = _Width;
            Y = _Height;
        }
        public override string GetArea()
        {
           double area= X * Y;
           return $"Rectangle area is: {area}.";
        }
    }
}
