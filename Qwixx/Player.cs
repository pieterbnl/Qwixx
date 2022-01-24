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
        internal int RollADice = 0;
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

        // Converts one or more passed integer values (representing dice eyes) to representing diceart
        // Returns the diceart in a list, containing all dice art in SB format
        // CHECK make a static method?
        internal List<StringBuilder[]> ConvertDiceToDiceArt(List<Dice> dices)
        {
            // Create a list that can hold Stringbuider values
            // Will be used to store dice art
            List<StringBuilder[]> dicesThrown = new List<StringBuilder[]>();

            // Iterate through all passed dices            
            foreach (Dice dice in dices)
            {
                // Check each dice eyes and add the related dice art
                switch (dice.Eyes)
                {
                    case 1:
                        dicesThrown.Add(DiceArt.DICE1);
                        break;
                    case 2:
                        dicesThrown.Add(DiceArt.DICE2);
                        break;
                    case 3:
                        dicesThrown.Add(DiceArt.DICE3);
                        break;
                    case 4:
                        dicesThrown.Add(DiceArt.DICE4);
                        break;
                    case 5:
                        dicesThrown.Add(DiceArt.DICE5);
                        break;
                    case 6:
                        dicesThrown.Add(DiceArt.DICE6);
                        break;
                    default:
                        break;
                }
            }
            // Return list with added SB dice art
            return dicesThrown;
        }
    }
}