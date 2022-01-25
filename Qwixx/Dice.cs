using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal class Dice
    {
        public string Color { get; set; } = "";
        public int Eyes { get; set; } = 0;

        // Constructor
        public Dice(string Color, int Eyes) 
        {
            this.Color = Color;
            this.Eyes = Eyes;
        }


        // Converts one or more passed integer values (representing dice eyes) to representing diceart
        // Returns the diceart in a list, containing all dice art in SB format
        // CHECK make a static method?
        internal static List<StringBuilder[]> ConvertDiceToDiceArt(List<Dice> dices)
        {
            // Create a list that can hold Stringbuider dice art            
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
