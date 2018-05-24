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

            string input = "xxxYxxXFDGDgx";

            Console.WriteLine(ConvertxToNothing(input));

            Console.ReadLine();
        }

        public static string ConvertxToNothing(string input)
        {
            string output = String.Empty;

            if (0 >= input.Length - 1)
            {
                if (input[0] != 'x')
                {
                    return input[0].ToString(); 
                }
                else
                {
                    return "";
                }
            }
            else
            {
                if (input[0] != 'x')
                {
                    output += input[0];

                    return output + ConvertxToNothing(input.Remove(0, 1)); 
                }
                else
                {
                    return output + ConvertxToNothing(input.Remove(0, 1));
                }
            }

        }
    }
}
