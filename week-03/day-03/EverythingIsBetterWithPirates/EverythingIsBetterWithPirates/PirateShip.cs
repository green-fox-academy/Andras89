using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverythingIsBetterWithPirates
{
    public class PirateShip
    {
        private static readonly Random RandomValue = new Random();

        private List<Pirate> PirateManifest = new List<Pirate>();
        private Pirate Captain;

        public PirateShip()
        {
            Captain = new Pirate();
        }

        public bool Battle(PirateShip otherBarge)
        {
            bool victory;
            bool draw;

            do
            {
                victory = IsVictory(otherBarge);
                draw = IsDraw(otherBarge);

                if (victory)
                {
                    Party();
                    otherBarge.RandomDeaths();
                }
                else if (draw)
                {
                    Party();
                    otherBarge.Party();
                }
                else
                {
                    RandomDeaths();
                    otherBarge.Party();
                } 
            } while (draw);

            return victory;
        }

        private bool IsVictory(PirateShip otherBarge)
        {
            return MembersAlive() - MembersPassedOut() + PirateManifest[0].HowDrunk() >
                   otherBarge.MembersAlive() - otherBarge.MembersPassedOut() + otherBarge.PirateManifest[0].HowDrunk();
        }

        private bool IsDraw(PirateShip otherBarge)
        {
            return MembersAlive() + PirateManifest[0].HowDrunk() - MembersPassedOut() ==
                   otherBarge.MembersAlive() + otherBarge.PirateManifest[0].HowDrunk() - otherBarge.MembersPassedOut();
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

            while(deathcount != 0 && aliveMemebers != 0)
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

        public int MembersPassedOut()
        {
            int counter = 0;

            foreach (Pirate pirate in PirateManifest)
            {
                if (pirate.IsPassedOut())
                {
                    counter++;
                }
            }

            return counter;
        }

        public string ShipStatus()
        {
            return $"The 'capitain' is (Alive / Passed Out):" +
                   $" {PirateManifest[0].IsAlive()} / {PirateManifest[0].IsPassedOut()} \n" +
                   $"From the {PirateManifest.Count} Crew there are {MembersAlive()} Pirates Alive \n";
        }


    }
}
