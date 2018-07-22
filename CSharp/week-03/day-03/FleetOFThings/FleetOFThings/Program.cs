using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            fleet = FleetOThings(fleet);
            PrintOut(fleet);

            Console.ReadLine();
        }

        public static void PrintOut(Fleet fleet)
        {
            foreach (Thing thing in fleet)
            {
                if (thing.IsComplete())
                {
                    for (int i = 0; i < thing.RecallName().Length; i++)
                    {
                        if (i == 4)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(thing.RecallName()[i]);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(thing.RecallName());
                }
            }
        }

        public static Fleet FleetOThings(Fleet fleet)
        {
            Thing thingOne = new Thing("1. [ ] Get milk");
            Thing thingTwo = new Thing("2. [ ] Remove the obstacles");
            Thing thingThree = new Thing("3. [ ] Stand up");
            Thing thingFour = new Thing("4. [ ] Eat lunch");

            thingThree.Complete();
            thingFour.Complete();

            fleet.Add(thingOne);
            fleet.Add(thingTwo);
            fleet.Add(thingThree);
            fleet.Add(thingFour);

            return fleet;
        }
    }
}
