using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSix
{
    public class TypeA
    {
        private int F;
        internal int G;
        public int H;
        public TypeA()
        {
            F = 0;
            G = 0;
            H = 0;
        }
        public TypeA(int f,int g,int h)
        {
            F = f;
            G = g;
            H = h;
        }
        public string DisblayValues()
        {
            return $"Value For F is '{F}', Value For G is '{G}', Value For H is '{H}'";
        }
    }
}
