using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
            Console.WriteLine(Calculate());
            Console.ReadLine();
        }

        public static string Calculate()
        {
            string operation = Console.ReadLine();
            int firstOperand = int.Parse(Console.ReadLine());
            int secondOperand = int.Parse(Console.ReadLine());

            string result = string.Empty;

            if (operation == "+")
            {
                result = (firstOperand + secondOperand).ToString();
                return result;
            }
            else if (operation == "-")
            {
                result = (firstOperand - secondOperand).ToString();
                return result;
            }
            else if (operation == "*")
            {
                result = (firstOperand * secondOperand).ToString();
                return result;
            }
            else if (operation == "/" && secondOperand != 0)
            {
                result = (firstOperand / secondOperand).ToString();
                return result;
            }
            else if (operation == "%" && secondOperand != 0)
            {
                result = (firstOperand % secondOperand).ToString();
                return result;
            }
            else
            {
                result = "Not a valid input";
                return result;
            }
        }
    }
}