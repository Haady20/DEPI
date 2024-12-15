using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentSeven
{
    public class Car : IMovable
    {
        public int id;
        public string brand;
        public double price;

        #region constructors

        public Car()
        {
            id = 0;
            brand = null;
            price = 0;

        }
        public Car(int _id)
        {
            id= _id;
        }

        public Car(int _id,string _brand)
        {
            id = _id;
            brand = _brand;
        }
        public Car(int _id, string _brand, double _price)
        {
            id = _id;
            brand = _brand;
            price = _price;
        }

        #endregion

        #region Methods
        public void Move()
        {
            Console.WriteLine($"{brand} is moving.");
        }
        #endregion
    }
}
