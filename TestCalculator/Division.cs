using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{

    public class Division : IMenu
    {
        public string Operation => "/";

        public double Execute(double a, double b)
        {
            if (b == 0) {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return a / b;
        }
    }
}
