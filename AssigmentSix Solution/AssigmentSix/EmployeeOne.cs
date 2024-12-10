using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSix
{
    public struct EmployeeOne
    {
        private int EmpId;
        private String Name;
        private double Salary;
    public EmployeeOne(int EmpId, String Name,double Salary)
        {
            this.EmpId=EmpId;
            this.Name=Name;
            this.Salary=Salary;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string input){
            Name = input ;
        }
        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double input)
        {
            Salary = input;
        }
        public string displayEmpDetails()
        {
            return $"Employee Id: {EmpId}, Name: {Name}, Salary: {Salary}.";
        }
    }
}