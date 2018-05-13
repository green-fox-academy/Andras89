using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstPractice();

            int sum = Add(4, 5);
            Console.WriteLine("\n" + sum);

            Console.ReadLine();
        }
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public static void FirstPractice()
        {
            int[] evenNumbers = new int[3];

            evenNumbers[0] = 0;
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }

            foreach (int item in evenNumbers)
            {
                Console.Write(item + ", ");
            }

        }

    }

}
