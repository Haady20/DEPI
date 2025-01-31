using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOne
{
    public delegate R Transformer<T, R>(T input);
    public class Transformer
    {
        public static List<R> TransformList<T, R>(List<T> inputList, Transformer<T, R> transform)
        {
            List<R> transformedList = new List<R>();
            foreach (var item in inputList)
            {
                transformedList.Add(transform(item));
            }
            return transformedList;
        }
    }
}
