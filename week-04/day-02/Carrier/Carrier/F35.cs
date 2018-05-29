using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrier
{
    public class F35 : Aircraft
    {
        public F35()
        {
            BaseDamage = 50;
            MaxAmmo = 12;
        }

        public override string GetType()
        {
            return "F35";
        }
    }
}
