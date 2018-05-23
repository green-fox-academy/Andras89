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
