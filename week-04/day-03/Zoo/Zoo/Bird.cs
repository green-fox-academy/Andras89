using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Bird : Animal, IFlyable
    {
        public Bird(string Name)
        {
            this.Name = Name;
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            Console.WriteLine("Cheerp!");
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void TakeOff()
        {
            throw new NotImplementedException();
        }

        public override string WantChild()
        {
            return "egg";
        }
    }
}
