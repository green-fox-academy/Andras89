using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            int numberOfNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            double avg = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            avg = sum / numberOfNumbers;

            Console.WriteLine(avg);
            Console.ReadLine();
        }
    }
}