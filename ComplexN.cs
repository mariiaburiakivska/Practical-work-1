using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public class ComplexN : IComplexN
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexN()
        {
            Real = 0;
            Imaginary = 0;
        }
        public ComplexN(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexN Add(IComplexN complex)
        {
            return new ComplexN(Real + complex.Real, Imaginary + complex.Imaginary);
        }

        public ComplexN AddToReal(double realNumber)
        {
            return new ComplexN(Real + realNumber, Imaginary);
        }

        public double Argument()
        {
            return Math.Atan2(Imaginary, Real);
        }

        public double Module()
        {
            return Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }

        public ComplexN Multiply(IComplexN complex)
        {
            double realPart = Real * complex.Real - Imaginary * complex.Imaginary;
            double imaginaryPart = Real * complex.Imaginary + complex.Real * Imaginary;

            return new ComplexN(realPart, imaginaryPart);
        }

        public ComplexN MultiplyByReal(double realNumber)
        {
            return new ComplexN(Real * realNumber, Imaginary * realNumber);
        }

        public ComplexN Subtract(IComplexN complex)
        {
            return new ComplexN(Real - complex.Real, Imaginary - complex.Imaginary);
        }

        public override bool Equals(object obj)
        {
            return obj is ComplexN complex &&
            Real == complex.Real &&
            Imaginary == complex.Imaginary;
        }

        public override string ToString()
        {
            return Imaginary >= 0 ? String.Format("{0} + {1}i", Real, Imaginary) : String.Format("{0} - {1}i", Real, Math.Abs(Imaginary));
        }
    }
}
