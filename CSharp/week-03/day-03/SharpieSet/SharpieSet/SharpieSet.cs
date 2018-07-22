using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class SharpieSet
    {
        private List<Sharpie> SharpList = new List<Sharpie>();

        public void Removetrash()
        {
            for (int i = 0; i < SharpList.Count; i++)
            {
                if(SharpList[i].NumberOfUsesLeft() == 0)
                {
                    SharpList.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Add(Sharpie sharpie)
        {
            SharpList.Add(sharpie);
        }

        public int CountUsable()
        {
            int counter = 0;

            for (int i = 0; i < SharpList.Count; i++)
            {
                if (SharpList[i].NumberOfUsesLeft() > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public void PrintOut()
        {
            foreach (Sharpie item in SharpList)
            {
                Console.Write($"{item.NumberOfUsesLeft()} ");
            }
        }
    }
}
