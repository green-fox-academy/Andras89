using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.WriteLine(factorio());
            Console.ReadLine();
        }

        public static int factorio()
        {
            int factNumber = int.Parse(Console.ReadLine());
            int factorialEquals = 1;
            for (int i = 1; i <= factNumber; i++)
            {
                factorialEquals *= i;
            }
            return factorialEquals;
        }
    }
}