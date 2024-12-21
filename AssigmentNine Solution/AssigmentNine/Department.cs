using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public class Department
    {
        public string Name { get; set; }

        public Department(string _Name)
        {
            Name = _Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
