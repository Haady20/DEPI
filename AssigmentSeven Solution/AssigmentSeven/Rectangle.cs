using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSeven
{
    internal class Rectangle : IShape 
    {
        public double width;
        public double height;
        public Rectangle(int _width,int _height) { 
            width = _width;
            height = _height;

        }
        public double Area
        {
            get { return width * height; }
        }

        public void Draw()
        {
            Console.WriteLine($"Rectangle Width is: '{width}', Rectangle Height is: '{height}'.");
        }

        public void PrintDetails()
        {
        }
    }
}
