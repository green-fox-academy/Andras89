using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Garden
    {
        private List<Plant> garden;

        public Garden()
        {
            garden = new List<Plant>()
            {
                new Flower("yellow"),
                new Flower("blue"),
                new Tree("purple"),
                new Tree("orange")
            };
        }


    }
}
