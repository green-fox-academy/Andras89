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
            set
            {
                ammoStore = value;
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

        public int Fight()
        {
            int damage = BaseDamage * AmmoStore;

            AmmoStore = 0;

            return damage;
        }

        public int ReFill(int allAmmo)
        {
            int indexer = ammoStore;

            for (int i = 0; i < MaxAmmo - indexer; i++)
            {
                if (allAmmo > 0)
                {
                    AmmoStore++;
                    allAmmo--;
                }
            }

            return allAmmo;
        }

        public virtual string GetType()
        {
            return "";
        }

        public string GetStatus()
        {
            return $"Type {GetType()}, Ammo: {AmmoStore}, Base Damage: {BaseDamage}, All Damage: {Fight()}";
        }

        public bool IsPriority()
        {
            return GetType() == "F35";
        }

        public int GetFullDamage()
        {
            int damage = BaseDamage * MaxAmmo;

            return damage;
        }
    }
}
