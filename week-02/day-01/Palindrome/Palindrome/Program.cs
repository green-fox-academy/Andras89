using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            Console.WriteLine(CreatePalindrome(firstWord));

            Console.ReadLine();
        }
        public static string CreatePalindrome(string word)
        {
            string tempWord = word;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                tempWord += word[i];
            }
            return tempWord;
        }
    }
}
