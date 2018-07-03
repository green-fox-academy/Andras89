using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<string> Tricks { get; set; }

        public string Drink { get; set; }
        public string Food { get; set; }

        public string Picture { get; set; }
        public int FoodAmount { get; set; }
        public int DrinkAmount { get; set; }

        public DateTime LastFeed { get; set; }
        public DateTime LastDrink { get; set; }

        public Fox()
        {
            Drink = "Water";
            Food = "Chicken";

            Picture = "Default Fox";

            FoodAmount = 20;
            DrinkAmount = 30;

            LastDrink = DateTime.Now;
            LastFeed = DateTime.Now;
        }
    }
}
