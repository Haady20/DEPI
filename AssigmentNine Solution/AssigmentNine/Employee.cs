using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public Employee(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
      
        }
        public Employee(string _Name, Department _Department)
        {
            Name = _Name;
            Department = _Department;
        }
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return Id == other.Id && Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name.ToLower());
        }
        public static class Helper2<T>
        {
            public static int SearchArray(T[] array, T item)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Equals(item))
                    {
                        return i; 
                    }
                }
                return -1; 
            }
        }
        public static Employee[] SearchArray(Employee[] employees, string departmentName)
        {
            return Array.FindAll(employees, emp => emp.Department.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase));
        }
        public override string ToString()
        {
            return $"{Name} (Department: {Department})";
        }
    }
}