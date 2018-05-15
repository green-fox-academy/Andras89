using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwapThis(list));
            // Expected output: "What I cannot create I do not understand." 

            Console.ReadLine();
        }

        public static string QuoteSwapThis(List<string> manyQuotesInTheSamePlace)
        {
            StringBuilder temp = new StringBuilder();
            int tempIndexOne = manyQuotesInTheSamePlace.IndexOf("do");
            int tempIndexTwo = manyQuotesInTheSamePlace.IndexOf("cannot");

            manyQuotesInTheSamePlace[tempIndexOne] = "cannot";
            manyQuotesInTheSamePlace[tempIndexTwo] = "do";

            foreach (string item in manyQuotesInTheSamePlace)
            {
                temp.Append(item + " ");
            }

            return temp.ToString();
        }
    }
}