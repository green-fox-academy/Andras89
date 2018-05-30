using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        private bool happiness;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public bool Happiness { get => happiness; set => happiness = value; }

        public abstract void Greet();
        public abstract string WantChild();

        public string GetName()
        {
            return Name;
        }
    }
}
