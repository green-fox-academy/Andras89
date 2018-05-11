using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int num = 0;
            double sum = 0;
            double avg = 0;

            for (int i = 0; i < 5; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }

            avg = sum / 5;
            Console.WriteLine(avg);

            Console.ReadLine();
        }
    }
}