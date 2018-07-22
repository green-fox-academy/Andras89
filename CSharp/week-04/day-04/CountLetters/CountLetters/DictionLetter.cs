using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class DictionLetter
    {
        public Dictionary<char, int> StringToDictionary(string word)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (dict.ContainsKey(word[i]))
                {
                    dict[word[i]]++;
                }
                else
                {
                    dict.Add(word[i], 1);
                }
            }

            return dict;
        }
    }
}
