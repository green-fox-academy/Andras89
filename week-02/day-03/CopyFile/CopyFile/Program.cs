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

            CopyContentOfFile(FilePath);

        }

        public static void CopyContentOfFile(List<string> FilePath)
        {
            string sourceFilePath = FilePath[0];
            string copyFilePath = FilePath[1];

            StreamReader sr = new StreamReader(sourceFilePath);
            StreamWriter sw = new StreamWriter(copyFilePath);

            string getLine = sr.ReadLine();
            sw.WriteLine(getLine);

            while(getLine != null)
            {
                getLine = sr.ReadLine();

                if (getLine != null)
                {
                    sw.WriteLine();
                }
            }
            sr.Dispose();
            sw.Dispose();
        }
    }
}
