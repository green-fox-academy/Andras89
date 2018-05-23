using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class SharpieSet : List<Sharpie>
    {
        private List<Sharpie> SharpList;

        public SharpieSet() { }

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

        public int CountUsable()
        {
            int counter = 0;
            foreach (Sharpie item in SharpList)
            {
                if(item.NumberOfUsesLeft() > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
