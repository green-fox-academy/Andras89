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
        Fox currentFox;

        public void CheckFox(string name)
        {
            throw new NotImplementedException();
        }

        public string GetDrink()
        {
            throw new NotImplementedException();
        }

        public string GetFood()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return currentFox.Name;
        }

        public List<string> GetTricks()
        {
            throw new NotImplementedException();
        }

        public void SetDrink(string drink)
        {
            throw new NotImplementedException();
        }

        public void SetFood(string food)
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            currentFox.Name = name;
        }

        public void SetTricks(string trick)
        {
            throw new NotImplementedException();
        }
    }
}
