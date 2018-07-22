using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            Console.WriteLine("Please give a number which with I will divide 10 with: ");

            int userInput = Int32.Parse(Console.ReadLine());

            Console.WriteLine(DivideTenWith(userInput));

            Console.ReadLine();

        }

        public static string DivideTenWith(int inputNumber)
        {
            int baseNumber = 10;

            try
            {
                baseNumber = baseNumber / inputNumber;
                return baseNumber.ToString();
            }
            catch (DivideByZeroException error)
            {
                return error.ToString();
            }

        }
    }
}