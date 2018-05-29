using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    public class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string sex, string previousOrganization) :base(name, age, sex)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} from {3}" +
                                 " who skipped {4} days from the course already."
                                 , Name, Age, previousOrganization, skippedDays );
        }

        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }
    }
}
