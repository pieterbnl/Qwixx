using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal static class DrawDice
    {        
        // Method to draw dice to console
        internal static void Draw(List<Dice> PlayerHand)
        {
            int count = 0;
            foreach (Dice dice in PlayerHand)
            {
                count = count + 1;
                Console.WriteLine("Dice " + count + "(" + dice.Color + ") eyes are: " + dice.Eyes);
            }
        }

        internal static void AddDiceToPlayerHand(int number)
        {
            switch (number)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                    
                    break;
            }
        }


        // Outputs concatated colored faces of passed dices, line by line
        // Requires input of a list with DiceArt StringBuilder faces        
        internal static void DisplayDices(List<StringBuilder[]> DicesThrown)
        {
            // Loop trough all (5) lines that make up a dice face
            for (int line = 0; line <= 4; line++)
            {
                // Loop through each thrown dice
                foreach (StringBuilder[] dice in DicesThrown)
                {
                    // Check the dice color and set the console display accordingly
                    switch (dice[5].ToString())
                    {
                        case "white":
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "red":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "green":
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case "yellow":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case "blue":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                    }

                    // Write line from dice, including some white space
                    Console.Write(dice[line]);
                    Console.Write("    ");

                }
                // Break line, as now all thrown dices are looped
                // and a full dice face line has been completed
                Console.WriteLine();
            }
        }
    }
}