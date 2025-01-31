using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOne
{
    internal class SortingAlgoritem2<T> where T : ICloneable, IComparable<T>
    {
        public void Sort(T[] array)
        {
            T[] clonedArray = CloneArray(array);
            for (int i = 0; i < clonedArray.Length - 1; i++)
            {
                for (int j = 0; j < clonedArray.Length - i - 1; j++)
                {
                    if (Comparer<T>.Default.Compare(clonedArray[j], clonedArray[j + 1]) > 0)
                    {
                        T temp = clonedArray[j];
                        clonedArray[j] = clonedArray[j + 1];
                        clonedArray[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Employees:");
            foreach (var employee in clonedArray)
            {
                var emp = (Employee)(object)employee;
                Console.WriteLine($"{emp.EmpName}: {emp.EmpSalary}.");
            }
        }

        private T[] CloneArray(T[] array)
        {
            T[] clonedArray = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                clonedArray[i] = (T)((ICloneable)array[i]).Clone();
            }
            return clonedArray;
        }
    }
}
