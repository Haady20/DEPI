using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public class Child : Parent
    {
        public Child(double _Salary) {
        Salary = _Salary;
        }
        
        public string DisplaySalary()
        {
            return $"Your Salary is: {Salary}.";
        }
    }
}
