using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal class Player    {
               
        // Class variables
        internal string? PlayerName { get; set; }
        internal int PlayerWins { get; set; } = 0;
        internal int PlayerLosses { get; set; } = 0;        
        internal int PlayerHighScore { get; set; } = 0;
        
        // CHECK: remove set? should only be changeable via seperate method
        internal List<Dice> PlayerHand { get; set; } = new List<Dice>();
        
        // internal List<StringBuilder[]> PlayerHandDiceArt = new List<StringBuilder[]>();        

        // Empty constructor
        public Player()
        {
            
        }

        // Constructor to create user directly with user's name
        public Player(string username)
        {
            PlayerName = username;
        }

        // Add a dice to the player's hand
        // Requires passing of dice color (string) and eyes (int)
        internal void AddDiceToPlayerHand(string color, int number)
        {
            PlayerHand.Add(new Dice(color, number));
        }

        // Clear player's hand, removing all dices
        internal void ClearPlayerHand()
        {
            PlayerHand.Clear();
        }

        // Get player's hand dice value of a given dice (index value)
        internal int PlayerDiceValue(int index)
        {
            return PlayerHand[index].Eyes;            
        }
    }
}