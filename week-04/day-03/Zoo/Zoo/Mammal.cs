using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Mammal : Animal
    {
        public Mammal(string Name)
        {
            this.Name = Name;
        }

        public override void Greet()
        {
            Console.WriteLine("Roar!");
        }

        public override string WantChild()
        {
            return "uterus";
        }
    }
}
