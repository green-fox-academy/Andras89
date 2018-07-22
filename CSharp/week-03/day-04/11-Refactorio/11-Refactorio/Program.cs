using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a recursive function called `refactorio`
            // that returns it's input's factorial

            int number = 3;

            Console.WriteLine(Refactor(number));
            Console.ReadLine();
        }

        public static int Refactor(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            else
            {
                return number * Refactor(number - 1);
            }
        }
    }
}
