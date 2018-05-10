using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            string firstRow = "% % % % ";
            string secondRow = " % % % %";

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(firstRow);
                }
                else
                {
                    Console.WriteLine(secondRow);
                }
            }
            Console.ReadLine();

        }
    }
}