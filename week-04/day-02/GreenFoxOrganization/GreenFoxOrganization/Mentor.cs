using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    public class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, string sex, string level) : base(name, age, sex)
        {
            this.level = level;
        }

        public Mentor()
        {
            level = "intermediate";
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Sex, level);
        }

        public override string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }
    }
}
