using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class FoxService : IFox
    {
        private List<Fox> foxDatabase = new List<Fox>();
        private Fox currentFox = new Fox() { Tricks = new List<string>(),
                                     Drink = "Water",
                                     Food = "Chicken"};

        private List<string> foxTricks = new List<string>() { "Play Dead", "Play Soccer", "Slight of Hand", "Pick Pocket",
                                                      "Bake Bread", "Make Goofy face"};

        private Stack<string> actionStack = new Stack<string>();

        public void CheckFox(string name)
        {
            actionStack.Push($"Changed to {name} at {DateTime.Now}");

            if (foxDatabase.Where(x => x.Name.Equals(name)).Count() == 0)
            {
                foxDatabase.Add(new Fox() { Name = name });
                currentFox = new Fox() { Tricks = new List<string>(),
                                         Drink = "Water",
                                         Food = "Chicken"
                };
                currentFox.Name = name;
            }
            else
            {
                currentFox = foxDatabase.Where(x => x.Name == name).ToList()[0];
            }
        }

        public List<string> ExcludeTrickList()
        {
            return foxTricks.Except(currentFox.Tricks).ToList();
        }

        public Stack<string> GetActionHistory()
        {
            return actionStack;
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
            actionStack.Push($"Changed {currentFox.Drink} to {drink} at {DateTime.Now}");
            currentFox.Drink = drink;
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Drink = drink;
        }

        public void SetFood(string food)
        {
            actionStack.Push($"Changed {currentFox.Food} to {food} at {DateTime.Now}");
            currentFox.Food = food;
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Food = food;
        }

        public void SetName(string name)
        {
            actionStack.Push($"Changed {currentFox.Name} to {name} at {DateTime.Now}");
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Name = name;
            currentFox.Name = name;
        }

        public void SetTricks(string trick)
        {
            actionStack.Push($"Added {trick} to current Fox at {DateTime.Now}");
            currentFox.Tricks.Add(trick);
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Tricks = new List<string>();
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Tricks = currentFox.Tricks;
        }
    }
}
