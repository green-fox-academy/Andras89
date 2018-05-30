using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Bird : Animal
    {
        public Bird(string Name)
        {
            this.Name = Name;
        }

        public override void Greet()
        {
            Console.WriteLine("Cheerp!");
        }

        public override string WantChild()
        {
            return "egg";
        }
    }
}
