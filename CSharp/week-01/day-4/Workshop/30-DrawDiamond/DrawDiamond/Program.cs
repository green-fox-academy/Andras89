using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            int num = int.Parse(Console.ReadLine());
            if (num % 2 != 0)
            {
                for (int i = 1; i <= (num / 2) + 1; i++)
                {
                    for (int j = 0; j < (num - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = (num) / 2; i >= 1; i--)
                {
                    for (int j = 0; j < (num - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= (num / 2); i++)
                {
                    for (int j = 0; j < (num - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = ((num) / 2); i >= 1; i--)
                {
                    for (int j = 0; j < (num - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadLine();

        }
    }
}