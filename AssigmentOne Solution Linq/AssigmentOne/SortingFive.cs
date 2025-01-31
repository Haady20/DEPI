using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOne
{
    public class SortingFive<T>
    {
        public void Sort(T[] array, Func<T, T, bool> comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    // Use the delegate to compare elements
                    if (!comparison(array[j], array[j + 1]))
                    {
                        // Swap
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
