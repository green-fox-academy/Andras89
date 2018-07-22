using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Postit postitOne = new Postit("Orange", "Blue", "Idea1");
            Postit postitTwo = new Postit("Pink", "Black", "Awesome");
            Postit postitThree = new Postit("Yellow", "Green", "Superb!");

            Console.WriteLine($"{postitOne.BackgroundColor} {postitOne.TextColor} {postitOne.Text}");

            Console.ReadLine();
        }
    }
    struct Postit
    {
        public string BackgroundColor;
        public string TextColor;
        public string Text;

        public Postit(string BackgroundColor, string TextColor, string Text)
        {
            this.BackgroundColor = BackgroundColor;
            this.TextColor = TextColor;
            this.Text = Text;
        }
    } 
}
