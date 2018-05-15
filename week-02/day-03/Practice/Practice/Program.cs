using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string Filename = @"C:\Green Fox\Andras89\week-02\day-03\Practice\Practice\mydoc.txt";

            WriteFile(Filename);
            ReadFile(Filename);

            StreamReader myReader = new StreamReader("Values.txt");

            string line = string.Empty;
            while (line != null)
            {
                line = myReader.ReadLine();
                if(line != null)
                {
                    Console.WriteLine(line);
                }
            }
            myReader.Close();

            string[] lines = { "This is a line", "This is a line", "This is a line" };

            try
            {
                int x = 1;
                int y = 1;
                double z = x / y;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            StreamReader sr = new StreamReader("Song.txt");
            string data = sr.ReadLine();
            while(data != null)
            {
                Console.WriteLine(data);
                string[] values = data.Split(',');
                int frequency = Int32.Parse(values[0]);
                int duration = Int32.Parse(values[1]);
                Console.Beep(frequency, duration);
                data = sr.ReadLine();
            }

            Console.ReadLine();
        }

        public static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "Hello World!");
        }
        public static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename)); 
        }
    }
}
