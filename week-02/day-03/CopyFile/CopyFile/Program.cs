using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            List<string> FilePath = new List<string>();
            FilePath.Add("Source.txt");
            FilePath.Add("CopiedFile.txt");

            Console.WriteLine(CopyContentOfFile(FilePath));

            Console.ReadLine();
        }

        public static bool CopyContentOfFile(List<string> FilePath)
        {

            try
            {
                File.WriteAllText(FilePath[1], File.ReadAllText(FilePath[0]));
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
    }
}
