using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    public class Sponsor : Person
    {
        private string company;
        private int studentsHired;

        public Sponsor()
        {
            company = "Google";
            studentsHired = 0;
        }

        public Sponsor(string name, int age, string sex, string company) : base(name, age, sex)
        {
            this.company = company;
            studentsHired = 0;
        }

        public override string Introduce()
        {
            return $"Hi, I'm {Name}, a {Age} year old {Sex}" +
                   $" who represents {company} and hired {studentsHired} students so far.";
        }

        public override string GetGoal()
        {
            return "Hire brilliant junior software developers.";
        }


    }
}
