using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int NumberAdder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return NumberAdder(n - 1) + n;
            }
        }
    }
}
