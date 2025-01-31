using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOne
{
    public delegate int IntOperation(int a, int b);
    public  class Oprerations
    {
        public static int PerformOperation(int a, int b, IntOperation operation)
        {
            return operation(a, b);
        }
    }
}
