using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(SumDigit(number));

            Console.ReadLine();
        }

        public static int SumDigit(int number)
        {
            int sum = 0;

            if (number / 10 == 0)
            {
                return (number % 10);
            }
            else
            {
                sum = (number % 10);

                return (sum + SumDigit(number / 10));
            }
        }
    }
}
