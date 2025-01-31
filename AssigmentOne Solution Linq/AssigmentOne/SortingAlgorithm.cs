using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOne
{
    public class SortingAlgorithm<T> //Bubble Sort Algorithm
    {
        public void Sort(T[] array, Comparison<T> comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparison(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        public void Swap(T[] array, int i, int j) {
            if (i < 0) {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            T temp=array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
