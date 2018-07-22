using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            string[] arrayWords = new string[] { firstWord, secondWord };
            Console.WriteLine(IsAnagram(arrayWords));
            Console.ReadLine();
        }
        public static bool IsAnagram(string[] array)
        {
            bool isAnag;
            string tempWord = "";
            for (int i = array[0].Length-1; i >=0 ; i--)
            {
                tempWord += array[0][i];
            }
            isAnag = (tempWord.Equals(array[1]));
            return isAnag;

        }
    }
}
