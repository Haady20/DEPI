using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentEight
{
    public class Robot : IWalkable
    {
        public string Place;
        public Robot(string _Place) { 
        Place = _Place;
        }
        public string Walk()
        {
            if (Place == "Street" || Place == "street")
            {
                return $"Robot is Walking.";
            }
            else
            {
                return $"Robot isn't Walking.";
            }
        }
    }
}
