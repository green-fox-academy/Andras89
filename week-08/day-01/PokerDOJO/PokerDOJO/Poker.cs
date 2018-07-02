using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerDOJO
{
    public class Poker
    {
        public int CardValue(string input)
        {
            return FigureValue(input[0].ToString());
        }

        public int FigureValue(string input)
        {
            try
            {
                int output = Int32.Parse(input);

                return output;
            }
            catch (Exception)
            {
                if (input.Equals("J"))
                {
                    return 11;
                }
                else if (input.Equals("Q"))
                {
                    return 12;
                }
                else if (input.Equals("K"))
                {
                    return 13;
                }
                else if (input.Equals("A"))
                {
                    return 14;
                }
                return 0;
            }
        }
    }
}
