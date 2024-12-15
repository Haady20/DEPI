using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSeven
{
    public class Child : Parent
    {
        public int Z;
    public Child(int x, int y, int z): base (x,y) {
            Z = z;
        }
        public new int Product()
        {
            return X * Y * Z;
        }
        //public override int Product()
        //{
        //    return X * Y * Z; 
        //}
        public override string ToString()
        {
            return $"Value of X:'{X}', Value of Y:'{Y}', Value of Z:'{Z}'.";

        }
    }
}
