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

            Dictionary<string, int> funkyDictionaryName = new Dictionary<string, int>();

            foreach (string word in splitReader)
            {
                if(word.Length == 4 && int.TryParse(word, out int n))
                {
                    if (funkyDictionaryName.ContainsKey(word))
                    {
                        funkyDictionaryName[word]++;
                    }
                    else
                    {
                        funkyDictionaryName.Add(word, 1);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
