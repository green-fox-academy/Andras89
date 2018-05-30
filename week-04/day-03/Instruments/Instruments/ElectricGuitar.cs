using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int NumberOfStrings)
        {
            this.NumberOfStrings = NumberOfStrings;
        }

        public ElectricGuitar()
        {
            NumberOfStrings = 6;
        }

        public override void Sound()
        {
            Console.WriteLine("Twang");
        }
    }
}
