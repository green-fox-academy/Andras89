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

        public int FibonacciMaker(char index)
        {
            int temp = index - '0';

            if(!Char.IsNumber(index))
            {
                throw new ArgumentException("It's Life Jim, But Not As We Know It!");
            }
            else if(temp < 0)
            {
                return 0;
            }
            else if(temp > 1)
            {
                for (int i = 0; i < temp - 1; i++)
                {
                    Fibonacci.Add(Fibonacci[i] + Fibonacci[i + 1]);
                }
            }

            return Fibonacci[temp];
        }
    }
}
