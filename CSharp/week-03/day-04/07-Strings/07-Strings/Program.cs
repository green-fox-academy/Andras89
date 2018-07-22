using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            string input = "xxxxxx";

            Console.WriteLine(ConvertxToy(input));

            Console.ReadLine();
        }

        public static string ConvertxToy(string input)
        {
            string output = String.Empty;

            if (0 >= input.Length - 1)
            {
                return input[0].ToString().Replace('x', 'y');
            }
            else
            {
                output += input[0].ToString().Replace('x', 'y');

                return output + ConvertxToy(input.Remove(0, 1));
            }

        }
    }
}
