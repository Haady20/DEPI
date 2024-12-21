using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;

namespace AssigmentEight
{
    public class Book
    {
        public string Title;
        public string Author;
        public Book(string _Title)
        {
            Title= _Title;
        }
        public Book(string _Title, string _Author)
        {
            Title = _Title;
            Author= _Author;
        }
        public override string ToString()
        {
            if (Author == null)
            {
                return $"Book Title is {Title}.";
            }
            else
            {
                return $"Book Title is: '{Title}', Book Author is: '{Author}'.";
            }
        }
    }
}
