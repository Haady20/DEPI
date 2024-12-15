using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSeven
{
    internal class Circle : IShape
    {
        public double redius;
        public Circle(double r)
        {
            redius = r;
        }
        public double Area 
        {
            get { return 3.14 * Math.Pow(redius,2); }
        }

        public void Draw()
        {

        }

        public void PrintDetails()
        {
            Console.WriteLine($"Circle redius is: '{redius}'.");
        }
    }
}
