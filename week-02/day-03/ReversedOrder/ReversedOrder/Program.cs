using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 
            string sourceFilePath = "revesed-order.txt";
            string destinationFilePath = @"../../solution.txt";
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
            List<string> tempReversalLineContainer = new List<string>();


            while (tempDataStorageLine != null)
            {
                if (tempDataStorageLine != null)
                {
                    tempReversalLineContainer.Insert(0, tempDataStorageLine);
                }                
                tempDataStorageLine = sr.ReadLine();
            }
            for (int i = 0; i < tempReversalLineContainer.Count; i++)
            {
                File.AppendAllText(filePath[1], tempReversalLineContainer[i] + "\n");
            }

        }
    }
}