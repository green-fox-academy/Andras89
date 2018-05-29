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

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public void Add(Aircraft plane)
        {
            carrier.Add(plane);
        }

        public void Fill()
        {
            do
            {
                for (int i = 0; i < carrier.Count; i++)
                {
                    if (carrier[i].isPriority())
                    {
                        ammo = carrier[i].ReFill(ammo);
                    }
                }
                for (int i = 0; i < carrier.Count; i++)
                {
                    if (!carrier[i].isPriority())
                    {
                        ammo = carrier[i].ReFill(ammo);
                    }
                } 
            } while (ammo > 0);
        }

        public void Fight(Carrier otherCarrier)
        {
            for (int i = 0; i < carrier.Count; i++)
            {
                otherCarrier.Health -= carrier[i].Fight();
            }
        }
    }
}
