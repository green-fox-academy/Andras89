using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface IFox
    {
        void SetName(string name);
        string GetName();

        void SetTricks(string trick);
        List<string> GetTricks();

        void SetFood(string food);
        string GetFood();

        void SetDrink(string drink);
        string GetDrink();

        void CheckFox(string name);
    }
}
