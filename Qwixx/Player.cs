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

        internal Scoreboard Scoreboard = new Scoreboard(); // holds a player's scoreboard
        
        // CHECK: remove set? should only be changeable via seperate method
        internal List<Dice> PlayerHandDices { get; set; } = new List<Dice>();
                
        // Empty constructor
        public Player()
        {
            
        }

        // Constructor to create user directly with user's name
        public Player(string username)
        {
            PlayerName = username;
        }        
    }
}