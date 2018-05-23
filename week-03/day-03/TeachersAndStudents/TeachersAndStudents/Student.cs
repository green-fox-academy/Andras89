using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersAndStudents
{
    class Student
    {
        private string Name;

        public Student()
        {
            
        }

        public void Learn()
        {
            Teacher teacher = new Teacher();
            teacher.Teach();
        }

        public void Question()
        {
            Console.WriteLine("Is this a question?");
        }
    }
}
