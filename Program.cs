namespace Pair_Programming
{
    class Players
    {
        private static void AssignPlayersToTeams(string[] players)
        {
            var pairing = new string[players.Length];
            Random random = new();
            players=players.OrderBy(shuffle => random.Next()).ToArray();
            for (var counter = 0; counter < players.Length; counter++)
            {
                pairing[counter]=players[random.Next(counter,players.Length)];
                players = players.Where(alreadyAssigned => alreadyAssigned != pairing[counter]).ToArray();
                
                //if our array.length is an Odd number
                if (counter == players.Length)
                {
                    Console.WriteLine("Team Number {0} : {1}" ,counter+1, pairing[counter]);
                    break;
                }
                Console.WriteLine("Team Number {0} : {1} and {2}",counter+1, pairing[counter], players[counter]);
            }
        }
        
        private static void Main()
        {
            string[] members =
            {
                "Adrian", "Aja", "Apshan", "Carl", "Eman", "Franco", "Hayley", "Ia", "Namita", "Nolan", "Sam",
                "Shannon", "Sherry", "Vahid", "Vijay" , "Vinu"
            };
            
            AssignPlayersToTeams(members);
        }
    }
}