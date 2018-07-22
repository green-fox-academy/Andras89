using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Farm
    {
        List<Animal> FarmAnimals = new List<Animal>();
        private int Slots;

        public Farm()
        {
            Slots = 20;
        }

        public void PrintAnimalDatas()
        {
            foreach (Animal item in FarmAnimals)
            {
                Console.Write($"[{item.AnimalData()[0]}, {item.AnimalData()[1]}] ");
            }
        }

        public void Slaugther()
        {
            if (FarmAnimals.Count >= 0)
            {
                int minIndex = 0;
                int lowestHunger = FarmAnimals[0].AnimalData()[0];

                for (int i = 0; i < FarmAnimals.Count; i++)
                {
                    if (FarmAnimals[i].AnimalData()[0] < lowestHunger)
                    {
                        minIndex = i;
                        lowestHunger = FarmAnimals[i].AnimalData()[0];
                    }
                }

                FarmAnimals.RemoveAt(minIndex);
                Slots++;
            }
        }

        public void Breed()
        {
            if (Slots > 0)
            {
                FarmAnimals.Add(new Animal());
                Slots--;
            }
        }
    }
}
