using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacciziator
    {
        public List<int> Fibonacci { get; set; }

        public Fibonacciziator()
        {
            Fibonacci = new List<int>() { 0, 1 };
        }

        public int FibonacciMaker(int index)
        {
            if(index.GetType() != typeof(int))
            {
                throw new ArgumentException("This is not a good sign, Jim!");
            }
            else if(index < 0)
            {
                return 0;
            }
            else if(index > 1)
            {
                for (int i = 0; i < index - 1; i++)
                {
                    Fibonacci.Add(Fibonacci[i] + Fibonacci[i + 1]);
                }
            }

            return Fibonacci[index];
        }
    }
}
