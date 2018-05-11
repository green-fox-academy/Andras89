using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (numOne > numTwo) { Console.WriteLine(numOne); }
            else if (numOne < numTwo) { Console.WriteLine(numTwo); }
            else { Console.WriteLine("They are equal"); }

            Console.ReadLine();
        }
    }
}