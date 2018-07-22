using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder todoTextRedone = new StringBuilder(todoText);
            todoTextRedone.Insert(0, "My todo:\n\t")
                          .Append("\t - Download games\n\t\t - Diablo");

            todoText = todoTextRedone.ToString();

            Console.WriteLine(todoText);

            Console.ReadLine();
        }
    }
}