using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public class Circle : Shape
    {
        public Circle(double _R) {
            X = _R;
        }
        public override string GetArea()
        {
            double area = 3.14 * Math.Pow(X, 2);
            return $"Circle area is: {area}.";
        }
    }
}
