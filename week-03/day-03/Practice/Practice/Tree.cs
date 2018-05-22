using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Tree
    {
        public string Type { get; set; }
        public string LeafColor { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public int MultiplyAgeWithAHundred()
        {
            Age = Age * 100;
            return Age;
        }
    }
}
