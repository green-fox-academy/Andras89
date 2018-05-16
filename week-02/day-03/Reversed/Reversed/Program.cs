using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reversed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts reversed-lines.txt 
            string sourceFilePath = "char.txt";
            string destinationFilePath = "solution.txt";
            List<string> filePathes = new List<string>();

            filePathes.Add(sourceFilePath);
            filePathes.Add(destinationFilePath);

            Decryptor(filePathes);

            Console.ReadLine();

        }

        public static void Decryptor(List<string> filePath)
        {
            StreamReader sr = new StreamReader(filePath[0]);
            string tempDataStorageLine = sr.ReadLine();
            string tempConcatCharsLine;

            while (tempDataStorageLine != null)
            {
                tempConcatCharsLine = string.Empty;

                if (tempDataStorageLine != null)
                {
                    for (int i = tempDataStorageLine.Length - 1; i >= 0; i--)
                    {
                        tempConcatCharsLine += tempDataStorageLine[i];
                    }
                }
                Console.WriteLine(tempConcatCharsLine);

                tempConcatCharsLine += "\n";
                File.AppendAllText(filePath[1], tempConcatCharsLine);
                tempDataStorageLine = sr.ReadLine();
            }

        }
    }
}