using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Station
    {
        private int GasAmount;
        
        public Station()
        {
            GasAmount = 10000;
        }

        public void Refill(Car car)
        {
            GasAmount -= car.ReturnCap();
            car.GasAmount = 100;
        }

        public int ReturnGasAmount()
        {
            return GasAmount;
        }
    }
}
