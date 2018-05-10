using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (firstNumber > secondNumber)
            {
                Console.WriteLine("Second number should be bigger");
                secondNumber = int.Parse(Console.ReadLine());
            }
            for (int i = firstNumber; i < secondNumber+1; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}