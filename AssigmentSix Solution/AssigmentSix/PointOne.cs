using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSix
{
    public struct PointOne
    {
        public int X;
        public int Y;
        public PointOne()
        {
            X = 0;
            Y = 0;
        }
        public PointOne(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Value For X is {X}, Value For Y is {Y}.";
        }

    }
}
