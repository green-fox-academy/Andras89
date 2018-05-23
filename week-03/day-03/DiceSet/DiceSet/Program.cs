using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceSet
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random RandomValue = new Random();
            Dice myDice = new Dice();
            myDice.GetCurrent();
            myDice.Roll();
            myDice.GetCurrent();
            myDice.GetCurrent(5);
            myDice.Reroll();
            myDice.GetCurrent();
            myDice.Reroll(4);
            myDice.GetCurrent();*/

            Dice handOfDice = new Dice();
            
            var dices = handOfDice.Roll();

            int sum;

            do
            {
                sum = 0;

                foreach (int item in dices)
                {
                    Console.Write($"[{item}] ");
                    sum += item;
                }

                Console.WriteLine();

                
                dices = handOfDice.Roll();

            } while (sum != dices.Length * 6);

            Console.ReadLine();
        }
    }
}
