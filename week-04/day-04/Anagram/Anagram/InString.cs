using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class InString
    {
        public bool AreAnagrams(string first, string second)
        {
            char[] temp = second.ToCharArray();
            temp.Reverse();
            second = new string(temp);

            return (first.ToLower() == second.ToLower());
        }
    }
}
