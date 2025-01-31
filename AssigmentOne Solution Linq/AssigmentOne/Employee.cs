using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssigmentOne
{
    public class Employee : ICloneable, IComparable<Employee>
    {
        public string EmpName { get; set; }
        public decimal EmpSalary { get; set; }

        public Employee(string name, decimal salary)
        {
            EmpName = name;  
            EmpSalary = salary; 
        }

        public object Clone()
        {
            return new Employee(EmpName, EmpSalary);
        }

        public int CompareTo(Employee other)
        {
            if(other == null) return 1; 
            return EmpSalary.CompareTo(other.EmpSalary); 
        }
    }
}
