using FoxClub.Models;
using FoxClub.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class FoxService : IFox
    {
        IFoxRepository foxes;

        public FoxService(IFoxRepository foxes)
        {
            this.foxes = foxes;
        }

        private List<Fox> foxDatabase = new List<Fox>();
        private Fox currentFox;

        private List<string> foxTricks = new List<string>() { "Bounce Walk", "Box", "Fart Stars", "Play Guitar",
                                                              "Bake Bread", "Smoke"};

        private Stack<string> actionStack = new Stack<string>();

        public void CheckFox(string name)
        {
            actionStack.Push($"Changed to {name} at {DateTime.Now}");

            if (foxDatabase.Where(x => x.Name.Equals(name)).Count() == 0)
            {
                foxDatabase.Add(new Fox() { Name = name });
                currentFox = new Fox() { Tricks = new List<string>(),
                                         Drink = "Water",
                                         Food = "Chicken",
                                         Picture = "Default Fox",
                                         FoodAmount = 10,
                                         DrinkAmount = 12,
                                         LastFeed = DateTime.Now,
                                         LastDrink = DateTime.Now
                };
                currentFox.Name = name;
            }
            else
            {
                currentFox = foxDatabase.Where(x => x.Name == name).ToList()[0];
            }
        }

        public void CheckNutritionTimer()
        {
            double drink = currentFox.LastDrink.Subtract(DateTime.Now).TotalMinutes;
            double food = currentFox.LastFeed.Subtract(DateTime.Now).TotalMinutes;

            SetDrinkAmount((int)drink);
            SetFoodAmount((int)food);
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

        public int GetDrinkAmount()
        {
            return currentFox.DrinkAmount;
        }

        public string GetFood()
        {
            return currentFox.Food;
        }

        public int GetFoodAmount()
        {
            return currentFox.FoodAmount;
        }

        public string GetName()
        {
            return currentFox.Name;
        }

        public string GetPicture()
        {
            return currentFox.Picture;
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

        public void SetDrinkAmount(int drink)
        {
            currentFox.LastDrink = DateTime.Now;

            currentFox.DrinkAmount += drink;
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].DrinkAmount += drink;

            if(currentFox.DrinkAmount < 1)
            {
                currentFox.Picture = "Dead Fox";
            }
        }

        public void SetFood(string food)
        {
            actionStack.Push($"Changed {currentFox.Food} to {food} at {DateTime.Now}");
            currentFox.Food = food;
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Food = food;
        }

        public void SetFoodAmount(int food)
        {
            currentFox.LastFeed = DateTime.Now;

            currentFox.FoodAmount += food;
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].FoodAmount += food;

            if(currentFox.FoodAmount < 1)
            {
                currentFox.Picture = "Dead Fox";
            }
        }

        public void SetName(string name)
        {
            actionStack.Push($"Changed {currentFox.Name} to {name} at {DateTime.Now}");
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Name = name;
            currentFox.Name = name;
        }

        public void SetPicture(string picture)
        {
            actionStack.Push($"Changed {currentFox.Picture} to {picture} at {DateTime.Now}");
            foxDatabase.Where(x => x.Name == currentFox.Name).ToList()[0].Picture = picture;
            currentFox.Picture = picture;
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
