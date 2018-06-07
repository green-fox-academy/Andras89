using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"../../birthdaysdata.txt";

            AGoodRubberDuckySaysNothing(filePath);
        }

        public static void AGoodRubberDuckySaysNothing(string filePath)
        {
            string reader = File.ReadAllText(filePath);

            string[] splitReader = reader.Split(';', '-');

            Console.ReadLine();
        }
    }
}
