using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public interface IComplexN
    {
        double Real { get; set; }
        double Imaginary { get; set; }

   
        ComplexN Add(IComplexN complex); 
        ComplexN Subtract(IComplexN complex); 
        ComplexN Multiply(IComplexN complex); 

        ComplexN AddToReal(double realNumber); 
        ComplexN MultiplyByReal(double realNumber);
        double Module();
        double Argument();

    }
}
