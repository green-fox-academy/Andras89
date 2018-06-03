using System;
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

            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }

            return max;
        }

        public double Median(List<int> pool)
        {
            if (pool.Count % 2 == 1)
            {
                return pool[(pool.Count - 1) / 2];
            }
            else
            {
                double output = (double)(pool[pool.Count / 2] + pool[pool.Count / 2 - 1]) / 2;
                return output;
            }
        }

        public bool IsVowel(char c)
        {
            string temp = c.ToString().ToLower();
            c = temp[0];

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
