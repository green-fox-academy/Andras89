using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Services
{
    public class GreetService : IGreet
    {
        private string name;

        public void SetName(string input)
        {
            name = input;
        }

        public string GetName()
        {
            return name;
        }
    }
}
