using System;

namespace DiceSet
{
    public class Dice
    {
        // You have a `DiceSet` class which has a list for 6 dices
        // You can roll all of them with roll()
        // Check the current rolled numbers with getCurrent()
        // You can reroll with reroll()
        // Your task is to roll the dices until all of the dices are 6
        static Random RandomValue = new Random();

        static int[] Dices = new int[6];

        public int[] Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
            return Dices;
        }

        public int[] GetCurrent()
        {
            return Dices;
        }

        public int GetCurrent(int i)
        {
            return Dices[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)
        {
            Dices[k] = new Random().Next(1, 7);
        }
    }
}