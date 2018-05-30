using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    public class Student : Person, ICloneable
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string sex, string previousOrganization) : base(name, age, sex)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public string PreviousOrganization { get => previousOrganization; set => previousOrganization = value; }

        public int SkippedDays { get => skippedDays; set => skippedDays = value; }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} from {3}" +
                                 " who skipped {4} days from the course already."
                                 , Name, Age, Sex, previousOrganization, skippedDays);
        }

        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }

        public void SkipDays(int DaysToSkip)
        {
            skippedDays += DaysToSkip;
        }

        public object Clone()
        {
            Student clone = new Student();

            clone.Name = this.Name;
            clone.Age = this.Age;
            clone.Sex = this.Sex;
            clone.PreviousOrganization = this.PreviousOrganization;
            clone.SkippedDays = this.SkippedDays;

            return clone;
        }
    }
}
