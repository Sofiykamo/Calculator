using System;

namespace TestCalculator
{
    public static class Instructions
    {
        public static void Show()
        {
            Console.WriteLine("\nInstructions:");
            Console.WriteLine("1. Enter the first number  (example - 4 or 4,1) ");
            Console.WriteLine("2. Enter the operation from this list ( + - * / )");
            Console.WriteLine("3. Enter the second number  (example - 4 or 4,1)");
            Console.WriteLine("4. Result will be displayed.");
            Console.WriteLine("Type 'exit' anytime to quit.\n");
        }
    }
}
