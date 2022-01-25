using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    // Represents a game scoreboard
    internal class Scoreboard
    {
        // Scoreboard containing of 6 rows
        // The first 4 rows holding the score lines OR crossed (cell 0 up to and inclusive 11)
        // (being: red 2--12 + lock, yellow 2--12 + lock, green 12--2 + lock, blue 12--2 + lock)
        // The 5th row holding "missed throws" (cell 0 up to and inclusive 3)
        // The 6th row holding the end game scores for each row (cell 0 up to and inclusive 5)
        // (being total score for red, yellow, green, blue, missed throws point withdrawl and total end score)

        internal string[,] PlayerScoreboard = new string[6, 12];

        // Fills the player's scoreboard with initial values
        internal void InitiateScoreboard()
        {
            // Iterate through first 4 rows
            for (int i = 0; i <= 3; i++)
            {
                // Iterate through 11 cells
                for (int j = 0; j <= 10; j++)
                {                    
                    if (i <= 1) // Row 1 + 2 require values 2 up to and inclusive 12
                    {
                       // Console.WriteLine("i: " + i + " & j: " + j);
                        PlayerScoreboard[i, j] = (2 + j).ToString();
                    }
                    else // Row 2 + 3 require values 12 down to and inclusive 2
                    {
                        PlayerScoreboard[i, j] = (12 - j).ToString();
                    }
                }
                // Setting initial final 'lock' score in scoreboard row to 0
                PlayerScoreboard[i, 11] = "0";
            }

            // Row 5: the missed throws                        
            PlayerScoreboard[4, 0] = "0";
            PlayerScoreboard[4, 1] = "0";
            PlayerScoreboard[4, 2] = "0";
            PlayerScoreboard[4, 3] = "0";

            // Row 6: the end game score values
            PlayerScoreboard[5, 0] = "0";
            PlayerScoreboard[5, 1] = "0";
            PlayerScoreboard[5, 2] = "0";
            PlayerScoreboard[5, 3] = "0";
            PlayerScoreboard[5, 4] = "0";
            PlayerScoreboard[5, 5] = "0";
        }
    }   
}