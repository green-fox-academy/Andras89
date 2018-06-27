using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public class AnagrammService : IAnagramm
    {
        private string anagramm;

        public bool CheckAnagramm(string input)
        {
            var temp = input.ToCharArray();
            Array.Reverse(temp);
            anagramm = string.Join("", temp);

            return input.ToLower().Equals(anagramm.ToLower());
        }
    }
}
