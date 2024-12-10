using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSix
{
    public struct PointThree
    {
        public int x;
        public int y;
        public PointThree(int x,int y)
        {
            this.x = x;
            this.y = y;
          
        }
        public int summition()
        {
            return x + y;
          
        }
        public override string ToString() {
            return $"Summition is '{summition()}'.";
        }
    }
}
