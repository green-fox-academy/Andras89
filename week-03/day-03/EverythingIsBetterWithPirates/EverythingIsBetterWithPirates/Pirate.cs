using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsBetterWithPirates
{
    class Pirate
    {
        private static readonly Random RandomValue = new Random();

        private int ToxicityLevel;
        private bool Awake;
        private bool Alive;

        public Pirate()
        {
            ToxicityLevel = 0;
            Awake = true;
            Alive = true;
        }

        public void PrintOut()
        {
            Console.WriteLine($"ToxLev: {ToxicityLevel}, Awake: {Awake}, Alive: {Alive}");
        }

        public void Brawl(Pirate otherSeaScum)
        {
            if (Alive && otherSeaScum.IsAlive())
            {
                int chances = RandomValue.Next(1,4);
                switch (chances)
                {
                    case 1:
                        Alive = false;
                        break;
                    case 2:
                        otherSeaScum.Die();
                        break;
                    case 3:
                        Awake = false;
                        otherSeaScum.PassOut();
                        break;
                }
            }
        }

        public int HowDrunk()
        {
            return ToxicityLevel;
        }

        public void PassOut()
        {
            Awake = false;
        }

        public bool IsPassedOut()
        {
            return !Awake;
        }

        public bool IsAlive()
        {
            return Alive;
        }

        public void Die()
        {
            Alive = false;
            ToxicityLevel = 0;
        }

        public void DrinkSomeRum()
        {
            if (Alive)
            {
                ToxicityLevel++;
            }
            else
            {
                Console.WriteLine("He's Dead, mate!");
            }
        }

        public void HowsItGoingMate()
        {
            if (Alive && Awake)
            {
                if (ToxicityLevel < 5)
                {
                    Console.WriteLine("Pour me anudder!");
                    ToxicityLevel++;
                }
                else
                {
                    Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                    ToxicityLevel = 0;
                    Awake = false;
                }
            }
            else
            {
                Console.WriteLine("He's Dead, mate!");
            }
        }

    }
}
