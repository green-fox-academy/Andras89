using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StringAgainAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            string input = "xxxxxxxx";
            Console.WriteLine(SeparateWithStar(input));

            Console.ReadLine();
        }

        public static string SeparateWithStar(string input)
        {
            string output = String.Empty;

            if (input.Length - 1 <= 0)
            {
                return input[0].ToString();
            }
            else
            {
                output += input[0] + "*";

                return output + SeparateWithStar(input.Remove(0, 1));
            }
        }
    }
}
