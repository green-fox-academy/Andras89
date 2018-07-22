using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Services
{
    public interface ICounter
    {
        int GetNumber();
        void Increment();
    }
}
