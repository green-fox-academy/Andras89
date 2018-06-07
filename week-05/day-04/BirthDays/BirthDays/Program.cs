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

            Console.WriteLine(AGoodRubberDuckySaysNothing(filePath));

            Console.ReadLine();
        }

        public static string AGoodRubberDuckySaysNothing(string filePath)
        {
            string mostBirthYears = String.Empty;

            string reader = File.ReadAllText(filePath);

            string[] splitReader = reader.Split(';', '-');

            Dictionary<string, int> funkyDictionaryName = new Dictionary<string, int>();

            foreach (string word in splitReader)
            {
                if (word.Length == 4 && int.TryParse(word, out int n))
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

            List<string> yearContainer = new List<string>();

            foreach (KeyValuePair<string, int> current in funkyDictionaryName)
            {
                if (yearContainer.Count == 0)
                {
                    yearContainer.Add(current.Key);
                }
                else if (current.Value > funkyDictionaryName[yearContainer[0]])
                {
                    yearContainer.Clear();
                    yearContainer.Add(current.Key);
                }
                else if(current.Value == funkyDictionaryName[yearContainer[0]])
                {
                    yearContainer.Add(current.Key);
                }
                else { }
            }

            foreach (string word in yearContainer)
            {
                mostBirthYears += $"{word}, ";
            }

            return mostBirthYears;
        }
    }
}
