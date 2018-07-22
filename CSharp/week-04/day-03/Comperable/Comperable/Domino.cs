using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comperable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object obj)
        {
            bool decide = snake[snake.Count - 1].GetValues()[1] == dominoes[i].GetValues()[0];
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
