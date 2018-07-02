using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerDOJO
{
    public class Poker
    {
        public bool IsFlush(string[] input)
        {
            return input.GroupBy(g => GetColor(g)).Where(x => x.Count() == 5) != null;
        }

        public bool IsFourOfAKind(string[] input)
        {
            return input.GroupBy(g => FigureValue(g)).Where(x => x.Count() == 4) != null;
        }

        public string GetColor(string input)
        {
            if(input.Length < 3)
            {
                return input[1].ToString();
            }
            else
            {
                return input[2].ToString();
            }
        } 

        public int HandValue(string[] input)
        {
            return input.Sum(x => CardValue(x));
        }

        public string[] SortHand(string[] input)
        {
            return input.ToList().OrderBy(x => CardValue(x)).ToArray();
        }

        public int CardValue(string input)
        {            
            if (input.Length < 3)
            {
                return FigureValue(input[0].ToString());
            }
            else
            {
                return 10;
            }
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
