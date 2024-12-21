using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Department;
        public Person(string _Name, int _Age, string _Department) {
            Name = _Name;
            Age = _Age;
            Department = _Department;
        } 
        public override string ToString()
        {
            return $"Name: '{Name}', Age: '{Age}', Department: '{Department}'.";
        }

    }
}
