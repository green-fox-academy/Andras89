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

        public int Ammo
        {
            get
            {
                return ammo;
            }
            set
            {
                ammo = value;
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
                    if (carrier[i].IsPriority())
                    {
                        Ammo = carrier[i].ReFill(Ammo);
                    }
                }
                for (int i = 0; i < carrier.Count; i++)
                {
                    if (!carrier[i].IsPriority())
                    {
                        Ammo = carrier[i].ReFill(Ammo);
                    }
                }
            } while (Ammo <= 0);
        }

        public void Fight(Carrier otherCarrier)
        {
            for (int i = 0; i < carrier.Count; i++)
            {
                otherCarrier.Health -= carrier[i].Fight();
            }
        }

        public string GetStatus()
        {
            string output = String.Empty;

            if (Health > 0)
            {
                output = $"HP: {Health}, Aircraft count: {carrier.Count}, Ammo Storage: {Ammo}, " +
                                    $"Total Damage: {GetTotalDamage()}\nAircrafts: \n";

                for (int i = 0; i < carrier.Count; i++)
                {
                    output += carrier[i].GetStatus() + "\n";
                }

                return output; 
            }
            else
            {
                output += "It' Dead Jim :(";
            }
        }

        private int GetTotalDamage()
        {
            int damage = 0;

            for (int i = 0; i < carrier.Count; i++)
            {
                damage += carrier[i].GetFullDamage();
            }

            return damage;
        }
    }
}
