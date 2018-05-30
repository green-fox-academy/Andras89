using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jane = new Student("Jane", 27, "Female", "Something");

            Student john = (Student)jane.Clone();

            Console.WriteLine(john.Introduce());

            Console.ReadLine();
        }
    }
}
