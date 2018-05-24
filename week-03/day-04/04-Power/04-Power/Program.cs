using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).

            int baseNum = 3;
            int expNum = 3;

            Console.WriteLine(Power(baseNum, expNum));

            Console.ReadLine();
        }

        public static int Power(int baseNum, int expNum)
        {
            if (expNum == 1)
            {
                return baseNum;
            }
            else
            {
                return baseNum * Power(baseNum, expNum - 1);
            }
        }
    }
}
