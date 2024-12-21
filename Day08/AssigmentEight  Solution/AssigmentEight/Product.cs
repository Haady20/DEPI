using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace AssigmentEight
{
    public class Product : IComparable<Product>
    {
        public int Id;
        public string Name;
        public double Price;
        public Product(int _Id, string _Name, double _Price) {
            Id = _Id;
            Name = _Name;
            Price = _Price;
        }

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return Price.CompareTo(other.Price);
        }
        public override string ToString() {
            return $"Id: {Id}, Name:{Name}, Price:{Price} ";
        }
    }
}
