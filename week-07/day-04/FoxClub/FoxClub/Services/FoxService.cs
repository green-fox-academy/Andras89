using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class FoxService : IFox
    {
        List<Fox> foxDatabase = new List<Fox>();
        Fox currentFox = new Fox() { Tricks = new List<string>() };

        public void CheckFox(string name)
        {
            if(foxDatabase.Where(x => x.Name.Equals(name)).Count() == 0)
            {
                foxDatabase.Add(new Fox() { Name = name });
                currentFox = new Fox() { Tricks = new List<string>() };
                currentFox.Name = name;
            }
            else
            {
                currentFox = foxDatabase.Where(x => x.Name == name).ToList()[0];
            }
        }

        public string GetDrink()
        {
            return currentFox.Drink;
        }

        public string GetFood()
        {
            return currentFox.Food;
        }

        public string GetName()
        {
            return currentFox.Name;
        }

        public List<string> GetTricks()
        {
            return currentFox.Tricks;
        }

        public void SetDrink(string drink)
        {
            currentFox.Drink = drink;
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Drink = drink;
        }

        public void SetFood(string food)
        {
            currentFox.Food = food;
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Food = food;
        }

        public void SetName(string name)
        {
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Name = name;
            currentFox.Name = name;
        }

        public void SetTricks(string trick)
        {
            currentFox.Tricks.Add(trick);
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Tricks = new List<string>();
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Tricks.Add(trick);
        }
    }
}
