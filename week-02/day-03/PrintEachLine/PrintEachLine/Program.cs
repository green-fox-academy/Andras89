using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"
            string fileName = "my-file.txt";

            PrintMyFile(fileName);

            Console.ReadLine();
        }
        public static void PrintMyFile(string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string getLine = sr.ReadLine();

                while (getLine != null)
                {
                    if (getLine != null)
                    {
                        Console.WriteLine(getLine);
                    }
                    getLine = sr.ReadLine();
                }
                sr.Dispose();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
        }
    }
}
