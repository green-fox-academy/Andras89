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
    }
}
