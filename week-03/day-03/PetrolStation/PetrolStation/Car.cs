using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Car
    {
        public int GasAmount;
        private int Capacity;

        public Car()
        {
            GasAmount = 0;
            Capacity = 100;
        }

        public int ReturnCap()
        {
            return Capacity;
        }
    }
}
