using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string 
            //where all the 'x' chars have been removed.

            string input = "xxxYxxx";

            Console.WriteLine(ConvertxToNothing(input));

            Console.ReadLine();
        }

        public static string ConvertxToNothing(string input)
        {
            string output = String.Empty;

            if (0 >= input.Length - 1)
            {
                return input[0].ToString();
            }
            else
            {
                output += input[0];

                return output + ConvertxToNothing(input.Remove(0, 1));
            }

        }
    }
}
