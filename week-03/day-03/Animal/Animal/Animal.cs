using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        /*
         Every animal has a hunger value, which is a whole number
        Every animal has a thirst value, which is a whole number
        when creating a new animal object these values are created with the default 50 value
        Every animal can eat() which decreases their hunger by one
        Every animal can drink() which decreases their thirst by one
        Every animal can play() which increases both by one*/

        private int Hunger;
        private int Thirst;

        public Animal()
        {
            Hunger = 50;
            Thirst = 50;
        }

        public void Eat()
        {
            Hunger--;
        }

        public void Drink()
        {
            Thirst--;
        }

        public void Play()
        {
            Hunger++;
            Thirst++;
        }

        public int[] AnimalData()
        {
            int[] animalData = new int[2];
            animalData[0] = Hunger;
            animalData[1] = Thirst;

            return animalData;
        }
    }
}
