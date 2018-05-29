using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrier
{
    public class Aircraft
    {
        private int maxAmmo;
        private int baseDamage;
        private int ammoStore;

        public Aircraft()
        {
            ammoStore = 0;
        }

        public int AmmoStore
        {
            get
            {
                return ammoStore;
            }
        }

        public int MaxAmmo
        {
            get
            {
                return maxAmmo;
            }
            set
            {
                maxAmmo = value;
            }
        }

        public int BaseDamage
        {
            get
            {
                return baseDamage;
            }
            set
            {
                baseDamage = value;
            }
        }
    }
}
