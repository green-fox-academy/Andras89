using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            Cohort fulvipes = new Cohort("FulVipes");

            fulvipes.AddMentor(new Mentor());
            fulvipes.AddMentor(new Mentor());
            fulvipes.AddMentor(new Mentor());

            fulvipes.AddStudent(new Student());
            fulvipes.AddStudent(new Student());
            fulvipes.AddStudent(new Student());
            fulvipes.AddStudent(new Student());
            fulvipes.AddStudent(new Student());
            fulvipes.AddStudent(new Student());
            fulvipes.AddStudent(new Student());

            Console.WriteLine(fulvipes.Info());

            Console.ReadLine();
        }
    }
}
