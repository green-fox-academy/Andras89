using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsBetterWithPirates
{
    class PirateShip
    {
        Random RandomValue = new Random();

        private List<Pirate> PirateManifest = new List<Pirate>();
        private Pirate Captain;

        public bool Battle(PirateShip otherBarge)
        {
            bool victory = (MembersAlive() + PirateManifest[0].HowDrunk() >
                            otherBarge.MembersAlive() + otherBarge.PirateManifest[0].HowDrunk());

            if (victory)
            {
                Party();
                otherBarge.RandomDeaths();
            }
            else
            {
                RandomDeaths();
                otherBarge.Party();
            }

            return victory;
        }

        public void Party()
        {
            for (int i = 0; i < PirateManifest.Count; i++)
            {
                if (PirateManifest[i].IsAlive())
                {
                    for (int j = 0; j < RandomValue.Next(0,7); j++)
                    {
                        PirateManifest[i].HowsItGoingMate();
                    }
                }
            }
        }

        public void RandomDeaths()
        {
            int deathcount = RandomValue.Next(0, PirateManifest.Count);
            int aliveMemebers = MembersAlive();

            while(deathcount != 0 || aliveMemebers != 0)
            {
                for (int i = PirateManifest.Count - 1; i >= 0; i--)
                {
                    if (PirateManifest[i].IsAlive() && deathcount > 0 && aliveMemebers > 0)
                    {
                        PirateManifest[i].Die();
                        deathcount--;
                        aliveMemebers--;
                    }
                }
            }
        }

        public void FillShip()
        {
            PirateManifest.Add(Captain);

            for (int i = 0; i < RandomValue.Next(0,21); i++)
            {
                PirateManifest.Add(new Pirate());
            }
        }

        public int MembersAlive()
        {
            int counter = 0;

            foreach (Pirate pirate in PirateManifest)
            {
                if (pirate.IsAlive())
                {
                    counter++;
                }
            }

            return counter;
        }

        public void ShipStatus()
        {
            Console.WriteLine($"The 'capitain' is (Alive / Passed Out):" +
                              $" {PirateManifest[0].IsAlive()} / {PirateManifest[0].IsPassedOut()}");
            Console.WriteLine($"From the {PirateManifest.Count} Crew there are {MembersAlive()} Pirates Alive");
        }


    }
}
