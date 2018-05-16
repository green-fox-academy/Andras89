using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Double
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 
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

            while(tempDataStorageLine != null)
            {
                tempConcatCharsLine = string.Empty;

                if(tempDataStorageLine != null)
                {
                    for (int i = 0; i < tempDataStorageLine.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            tempConcatCharsLine += tempDataStorageLine[i];
                        }
                    }
                }
                Console.WriteLine(tempConcatCharsLine);

                tempConcatCharsLine += " | ";
                File.AppendAllText(filePath[1], tempConcatCharsLine);
                tempDataStorageLine = sr.ReadLine();
            }

        }
    }
}
