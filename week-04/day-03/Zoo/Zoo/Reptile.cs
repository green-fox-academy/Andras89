using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Reptile : Animal
    {
        public Reptile(string Name)
        {
            this.Name = Name;
        }

        public override void Greet()
        {
            Console.WriteLine("Slither!");
        }

        public override string WantChild()
        {
            return "egg";
        }
    }
}
