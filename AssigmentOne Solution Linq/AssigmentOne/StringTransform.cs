using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOne
{
    public delegate string StringTransform(string input);
    public class StringTransformer
    {
public static List<string> TransformList(List<string> inputList, StringTransform transform)
        {
            List<string> transformedList = new List<string>();
            foreach (var item in inputList)
            {
                transformedList.Add(transform(item));
            }
            return transformedList;
        }
    }
}
