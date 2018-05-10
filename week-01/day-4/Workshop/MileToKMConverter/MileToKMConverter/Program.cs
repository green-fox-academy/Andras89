using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            int km;
            double mile;

            Console.WriteLine("Add kilometer to be converted");
            km = int.Parse(Console.ReadLine());

            mile = km * 1.6;
            Console.WriteLine(mile);

            Console.ReadLine();
        }
    }
}