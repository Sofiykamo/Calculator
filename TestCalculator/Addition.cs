using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public class Addition : IMenu
    {
        public string Operation => "+";

        public double Execute(double a, double b)
        {
            return a + b;
        }
    }
}
