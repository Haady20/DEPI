using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOne
{
    public class Manager : Employee, IComparable<Manager>
    {
        public Manager(string name, decimal salary) : base(name, salary)
        {
        }

        public int CompareTo(Manager other)
        {
            if (other == null) return 1;
            return EmpSalary.CompareTo(other.EmpSalary);
        }
    }
    public class SortingFour<T>
    {
        public void Sort(T[] array, Comparison<T> comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparison(array[j], array[j + 1]) < 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}

