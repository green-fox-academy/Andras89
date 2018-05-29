using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrier
{
    public class Carrier
    {
        private List<Aircraft> carrier;
        private int ammo;
        private int health;

        public Carrier(int health, int ammo)
        {
            this.health = health;
            this.ammo = ammo;

            carrier = new List<Aircraft>();
        }
    }
}
