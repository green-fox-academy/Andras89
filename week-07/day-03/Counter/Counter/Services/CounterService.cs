using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public class CounterService : ICounter
    {
        public int counter = 0;

        public int GetNumber()
        {
            return counter;
        }

        public void Increment()
        {
            counter++;
        }
    }
}
