using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
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
