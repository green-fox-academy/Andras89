using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string Filename = @"C:\Green Fox\Andras89\week-02\day-03\Practice\mydoc.txt";

            WriteFile(Filename);


            ReadFile(Filename);
        }

        public static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "Helo World!");
        }
        public static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename)); 
        }
    }
}
