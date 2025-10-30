using System.Collections.Generic;
using System.Linq;

namespace TestCalculator
{
    public class Calculator
    {
        private readonly List<IMenu> _operations;

        public Calculator()
        {
            _operations = new List<IMenu>
            {
                new Addition(),
                new Subtraction(),
                new Multiplication(),
                new Division()
            };
        }

        public IReadOnlyList<IMenu> Operations => _operations;

        public double Calculate(double a, string op, double b)
        {
            var operation = _operations.FirstOrDefault(o => o.Operation == op);
               if (operation == null)
            {
                throw new ArgumentException($"Operation '{op}' is not supported.");
            }

            return operation.Execute(a, b);
        }
    }
}