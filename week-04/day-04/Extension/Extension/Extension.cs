﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            int c = a + b;

            return c;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            int max = a;

            if(max < b)
            {
                max = b;
            }
            if(max < c)
            {
                max = c;
            }

            return max;
        }

        public int Median(List<int> pool)
        {
            return pool[(pool.Count - 1) / 2];
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'u', 'o', 'e', 'i' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;
            for (int i = 0; i < length; i++)
            {
                char c = teve[i];
                if (IsVowel(c))
                {
                    teve = string.Join(c + "v" + c, teve.Split(c));
                    i += 2;
                    length += 2;
                }
            }

            return teve;
        }
    }
}