using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentNine
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public ComplexNumber(double _Real, double _Imaginary)
        {
            Real = _Real;
            Imaginary = _Imaginary;
        }
        public static ComplexNumber operator *(ComplexNumber X, ComplexNumber Y)
        {
            double realPart = (X.Real * Y.Real) - (X.Imaginary * Y.Imaginary);
            double imaginaryPart = (X.Real * Y.Imaginary) + (X.Imaginary * Y.Real);
            return new ComplexNumber(realPart, imaginaryPart);
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}";
        }
    }
}
