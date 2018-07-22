using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class Fleet : List<Thing>
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }
    }
}
