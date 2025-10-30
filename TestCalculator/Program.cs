// See https://aka.ms/new-console-templafkt te for more information
//Console.WriteLine("Hello, World!");


using System;

namespace TestCalculator
{
    class Program
    {
        static void Main()
        {
            var calculator = new Calculator();

            Console.WriteLine("Hello, Calculator!");
            Console.Write("Do you want to see instructions? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                Instructions.Show();
            }

            while (true)
            {
                try
                {
                    Console.Write("\nEnter first number (or 'exit' to quit): ");
                    string input1 = Console.ReadLine();
                    if (input1.ToLower() == "exit") break;

                    if (!double.TryParse(input1, out double a))
                    {
                        Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                        continue;
                    }

                    Console.Write("Enter operation (+ - * /): ");
                    string op = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(op))
                    {
                        Console.WriteLine("Error: Operation cannot be empty.");
                        continue;
                    }

                    Console.Write("Enter second number: ");
                    string input2 = Console.ReadLine();
                    if (!double.TryParse(input2, out double b))
                    {
                        Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                        continue;
                    }

                    
                    double result = calculator.Calculate(a, op, b);

                    Console.WriteLine($"Result: {a} {op} {b} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }

            Console.WriteLine("\nThank you for using the calculator!");
            EndProgram();
        }

        static void EndProgram()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

