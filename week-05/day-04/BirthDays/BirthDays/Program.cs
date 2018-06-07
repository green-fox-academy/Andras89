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

            string reader = File.ReadAllText(filePath);

            string[] splitReader = reader.Split(';');
        }
    }
}
