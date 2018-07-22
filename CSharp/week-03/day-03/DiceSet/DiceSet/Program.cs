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
            Dice handOfDice = new Dice();

            var dices = handOfDice.Roll();

            GetSixes(dices);

            Console.ReadLine();
        }

        public static void GetSixes(int[] dices)
        {
            Dice handOfDice = new Dice();

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
        }
    }
}
