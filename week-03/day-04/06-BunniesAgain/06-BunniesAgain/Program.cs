using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            int numberOfRodents = 3;

            Console.WriteLine(BunnieEarCounter(numberOfRodents));

            Console.ReadLine();
        }

        public static int BunnieEarCounter(int numberOfRodents)
        {
            int sum = 0;

            if (numberOfRodents == 2)
            {
                sum += 3;

                return sum + BunnieEarCounter(numberOfRodents - 1);
            }
            else if (numberOfRodents == 1)
            {
                return 2;
            }
            else
            {
                if(numberOfRodents % 2 == 1)
                {
                    sum += 2;

                    return sum + BunnieEarCounter(numberOfRodents - 1);
                }
                else
                {
                    sum += 3;

                    return sum + BunnieEarCounter(numberOfRodents - 1);
                }
            }
        }
    }
}
