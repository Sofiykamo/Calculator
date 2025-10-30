using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public interface IMenu
    {
        string Operation { get; }  
        double Execute(double a, double b);
    }
}
