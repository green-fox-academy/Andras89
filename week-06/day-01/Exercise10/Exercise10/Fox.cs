using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    public class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }
    }
}
