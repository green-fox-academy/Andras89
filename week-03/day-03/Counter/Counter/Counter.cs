using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        private int Sum;

        public Counter()
        {
            Sum = 0;
        }

        public Counter(int Sum)
        {
            this.Sum = Sum;
        }

        public void Add(int number)
        {
            Sum += number;
        }

        public void Add()
        {
            Sum++;
        }

        public string Get()
        {
            string result = Sum.ToString();
            return result;
        }

        public void Reset()
        {
            Sum = 0;
        }
    }
}
