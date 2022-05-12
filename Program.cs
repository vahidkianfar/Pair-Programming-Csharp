using System;
using System.Linq;

namespace Pair_Programming
{
    class Players
    {
        private void AssignPlayersToTeams(string[] players)
        {
            //This function is not followed by SOLID principles.
            
            string[] pairing = new string[players.Length];
            Random random = new Random();
            players = players.OrderBy(x => random.Next()).ToArray();
            for (int i = 0; i < players.Length-1; i++)
            {
                pairing[i]=players[random.Next(i,players.Length)];
                players = players.Where(x => x != pairing[i]).ToArray();
                Console.WriteLine("Team Number {0} : {1} and {2}",i+1, pairing[i], players[i]);
            }
        }
        static void Main(string[] args)
        {
            string[] players =
            {
                "Adrian", "Aja", "Apshan", "Carl", "Eman", "Franco", "Hayley", "Ia", "Namita", "Nolan", "Sam",
                "Shannon", "Sherry", "Vahid", "Vijay", "Vinu"
            };
            
            Players teams = new();
            teams.AssignPlayersToTeams(players);
        }
    }
}