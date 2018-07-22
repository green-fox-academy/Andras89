using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> Tricks { get; set; }

        public string Drink { get; set; }
        public string Food { get; set; }

        public string Picture { get; set; }
        public int FoodAmount { get; set; }
        public int DrinkAmount { get; set; }

        public DateTime LastFeed { get; set; }
        public DateTime LastDrink { get; set; }
    }
}
