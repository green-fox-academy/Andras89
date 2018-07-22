using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Counter(n)); 

            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return Counter(n - 1); 
            }
        }
    }
}
