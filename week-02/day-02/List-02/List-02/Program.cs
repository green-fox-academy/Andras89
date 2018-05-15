using System;
using System.Collections.Generic;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            Dictionary<string, string> allThePairs = new Dictionary<string, string>();

            allThePairs = MatchmakingMethod(girls, boys);

            foreach (KeyValuePair<string, string> member in allThePairs)
            {
                Console.WriteLine(member.Key + " : " + member.Value);
            }
            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.ReadLine();
        }

        public static Dictionary<string, string> MatchmakingMethod(List<string> girls, List<string> boys)
        {
            Dictionary<string, string> inputThePeople = new Dictionary<string, string>();
            for (int i = 0; i < girls.Count; i++)
            {
                inputThePeople[girls[i]] = boys[i];
            }

            return inputThePeople;
        }
    }
}