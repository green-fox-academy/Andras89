using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    public class Person
    {
        private string name;
        private int age;
        private string sex;

        public Person(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            sex = "female";
        }

        public string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2}.", name, age, sex);
        }

        public virtual string GetGoal()
        {
            return "My goal is: Live for the moment!";
        }
    }
}
