﻿using System;
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
            string sampleString1 = "ThisIsaString";

            Console.WriteLine(SubStringGenerator(sampleString1).ToUpper());
            Console.WriteLine(SubStringGenerator(sampleString1).ToLower());

            Console.ReadLine();
        }

        public static string SubStringGenerator(string word)
        {
            word = word.Substring(1, 6);
            return word;
        }
    }
}
