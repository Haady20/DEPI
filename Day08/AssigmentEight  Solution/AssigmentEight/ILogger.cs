using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public interface ILogger
    {
        void log()
        {
            Console.WriteLine("Default Log Method From Interface");
        }
    }
}
