using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies
            //recursively (without loops or multiplication).

            int numberOfBunnies = 8;

            Console.WriteLine(BunnyEarCounter(numberOfBunnies));

            Console.ReadLine();
        }

        public static int BunnyEarCounter(int numberOfBunnies)
        {
            int sum = 0;
            if (numberOfBunnies == 1)
            {
                return 2;
            }
            else
            {
                sum += 2;
                return sum + BunnyEarCounter(numberOfBunnies - 1);
            }
        }
    }
}
