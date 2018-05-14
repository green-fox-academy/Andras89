using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "dog goat dad duck doodle never";
            string[] palindromeArray = SearchPalindrome(word);

            for (int i = 0; i < palindromeArray.Length; i++)
            {
                Console.Write(palindromeArray[i] + ", ");
            }

            Console.ReadLine();
        }

        public static string[] SearchPalindrome(string word)
        {
            string[] palindromeArray = new string[7];
            int index = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 1; j < word.Length - i; j++)
                {
                    if (IsPalindrome(word.Substring(i, j)) && word.Substring(i, j).Length >= 3)
                    {
                        palindromeArray[index] = word.Substring(i, j);
                        index++;
                    }
                }
            }

            return palindromeArray;
        }

        public static bool IsPalindrome(string word)
        {
            bool palindrome = false;
            string tempWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                tempWord += word[i];  
            }

            if (tempWord.Equals(word, StringComparison.CurrentCultureIgnoreCase))
            {
                palindrome = true;
            }
            return palindrome;
        }
    }
}
