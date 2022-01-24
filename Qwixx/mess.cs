using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal class mess
    {

        
        /*
         * DICTIONARY TRIALS
         * 
         * // Create unsorted and sorty dictionary
        Dictionary<Player, int> PlayersUnsorted = new Dictionary<Player, int>();
        Dictionary<Player, int> PlayersSorted = new Dictionary<Player, int>();

        // Add players to unsorted dictionary
        PlayersUnsorted.Add(PlayerOne, 0);
            PlayersUnsorted.Add(PlayerTwo, 0);
            PlayersUnsorted.Add(PlayerThree, 0);
            PlayersUnsorted.Add(PlayerFour, 0);

            // Loop through all players in unsorted dictionary
            foreach (KeyValuePair<Player, int> player in PlayersUnsorted)
            {
                // Make selected player roll a dice
                while (userMenuSelection != "R")
                {
                    Console.WriteLine(player.Key.PlayerName + "! Ready to roll a dice? Press [R] to roll!");                    
                    userMenuSelection = Console.ReadLine().ToUpper();
    }
    PlayerRoleScore = RollDice.Roll();

                // Copy player object with rolled dice value to sorted dictionary
                // AS I DO NOT KNOW HOW TO UPDATE A VALUE IN A DICT
                // (REQUIRING REFERENCING TO KEY: IN THIS CASE BY OBJECT)
                PlayersSorted.Add(player.Key, PlayerRoleScore);

                // TEMP: check values - HOW TO GET KEY VALUE?
                Console.WriteLine(player.Key.PlayerName + " rolls " + player.Key);
                userMenuSelection = "";
            }

var sortedDict = from player in PlayersSorted orderby player.Value descending select player;
int i = 1;
foreach (KeyValuePair<Player, int> player in PlayersSorted)
{
    Console.WriteLine("Player " + i + " = " + player);
    i++;
}

*/
    
    }

}
