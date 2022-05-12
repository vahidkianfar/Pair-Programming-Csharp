using System;
using System.Linq;

namespace Pair_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players =
            {
                "Adrian", "Aja", "Apshan", "Carl", "Eman", "Franco", "Hayley", "Ia", "Namita", "Nolan", "Sam",
                "Shannon", "Sherry", "Vahid", "Vijay", "Vinu"
            };
            Random random = new Random();
            players = players.OrderBy(x => random.Next()).ToArray();
            string[] pairing = new string[players.Length];

            for (int i = 0; i < players.Length-1; i++)
            {
                pairing[i]=players[random.Next(i,players.Length)];
                players = players.Where(x => x != pairing[i]).ToArray();
                //Console.WriteLine(pairing[i]);
                Console.WriteLine("Team Number {0} : {1} and {2}",i+1, pairing[i], players[i]);
            }
        }
    }
}