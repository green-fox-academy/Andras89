using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleString1 = "ThisIsaString  ";
            string sampleString2 = "string1,string2,string3,string4,string5,string6";

            string[] words = sampleString2.Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            string joinedString = string.Join(",", words);
            Console.WriteLine(joinedString);

            sampleString1 = sampleString1.Trim();

            Console.WriteLine(sampleString1.Replace("This", "AppleJuice"));

            Console.WriteLine(SubStringGenerator(sampleString1).ToUpper());
            Console.WriteLine(SubStringGenerator(sampleString1).ToLower());

            string sampleEmptyString = string.Empty;

            if (string.IsNullOrEmpty(sampleEmptyString))
            {

            }

            Console.ReadLine();
        }

        public static string SubStringGenerator(string word)
        {
            word = word.Substring(1, 6);
            return word;
        }
    }
}
