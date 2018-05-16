using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            string fileName = "my-file.txt";

            Console.WriteLine(CountLine(fileName)); 

            Console.ReadLine();
        }
        public static int CountLine(string fileName)
        {
            int counter = 0;

            try
            {
                StreamReader sr = new StreamReader(fileName);
                string getLine = sr.ReadLine();
                counter++;
                while (getLine != null)
                {
                    if (getLine != null)
                    {
                        counter++;
                    }
                    getLine = sr.ReadLine();
                }
                sr.Dispose();

                return counter;
            }
            catch (Exception)
            {
                return counter;
            }
        }
    }
}