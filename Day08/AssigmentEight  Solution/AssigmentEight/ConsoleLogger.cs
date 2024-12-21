using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public class ConsoleLogger : ILogger
    {
        
         public void log()
        {
            Console.WriteLine("Overrided Log Method From Class");
        }
    }
}
