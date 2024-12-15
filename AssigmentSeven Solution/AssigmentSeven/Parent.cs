using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSeven
{
    public class Parent 
    {
        public int X;
        public int Y;
        public Parent(int x,int y) {
            X = x;
            Y = y;
        }
        public virtual int Product()
        {
            int result = X * Y;
            return result;
        }
        public override string ToString()
        {
            return $"Value of X:'{X}', Value of Y:'{Y}.";

        }
    }
}
