using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
            Console.WriteLine(sum());
            Console.ReadLine();
        }

        public static int sum()
        {
            int sum = 0;
            int numberOfSummedNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSummedNumbers; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            return sum;
        }
    }
}