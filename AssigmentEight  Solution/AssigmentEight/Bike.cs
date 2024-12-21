using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public class Bike : IVehicle
    {
        public string Start;
        public string End;
        public Bike(string _Start,string _End) {
            Start = _Start.Trim();
            End = _End.Trim();
        }   
        public string StartEngine()
        {
            return $"Start From {Start}.";
        }

        public string StopEngine()
        {
            return $"Stop in {End}.";
        }
    }
}
