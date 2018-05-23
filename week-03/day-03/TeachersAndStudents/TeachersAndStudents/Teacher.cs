using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersAndStudents
{
    class Teacher
    {
        private string Name;

        public Teacher()
        {
            
        }

        public void Teach()
        {
            Student student = new Student();
            student.Learn();
        }

        public void Answer()
        {
            Console.WriteLine("This is the answer!");
        }
    }
}
