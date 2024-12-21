using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double _length, double _width)
        {
            Length = _length;
            Width = _width;
        }
        public override string ToString()
        {
            return $"Rectangle(Length: {Length}, Width: {Width})";
        }
    }

}
