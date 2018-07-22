using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public class AnagrammService : IAnagramm
    {
        private bool isAnagramm;
        private string anagramm;

        public void CheckAnagramm(string input)
        {
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            anagramm = string.Join("", temp);

            isAnagramm = input.ToLower().Equals(anagramm.ToLower());
        }

        public bool GetAnagramm()
        {
            return isAnagramm;
        }
    }
}
