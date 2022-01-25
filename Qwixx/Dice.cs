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

        // Returns a given dice with random eyes
        internal static Dice RollADice(Dice dice)
        {            
            Random value = new Random();
            dice.Eyes = value.Next(1, 7);
            return dice;
        }

        // Returns a dice at given index in a hand of dices, with random eyes
        internal static List<Dice> RollADiceInAHand(List<Dice> dices, int index)
        {
            Random value = new Random();
            dices[index].Eyes = value.Next(1, 7);
            return dices;
        }

        /*
                // Generate a rolled dice eyes
                internal static int RollADice()
                {
                    Random dice = new Random();
                    return dice.Next(1, 7);
                }*/

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

            // Return console display color to normal
            Console.ForegroundColor = ConsoleColor.White;
        }

        /*// Draw dice to console - OBSOLETE
        internal static void Draw(List<Dice> PlayerHand)
        {
            int count = 0;
            foreach (Dice dice in PlayerHand)
            {
                count = count + 1;
                Console.WriteLine("Dice " + count + "(" + dice.Color + ") eyes are: " + dice.Eyes);
            }
        }*/

        // Adds all initial dices to game
        internal static List<Dice> AddDicesToGame(List<Dice> dices)
        {
            AddADice("white",1, dices);
            AddADice("white", 1, dices);
            AddADice("blue", 1, dices);
            AddADice("green", 1, dices);
            AddADice("yellow", 1, dices);
            AddADice("red", 1, dices);

            return dices;
        }
                
        // Add's a dice to a given list with dices
        // Requires passing a dice color (string) and eyes (int)
        internal static List<Dice> AddADice(string color, int number, List<Dice> dices)
        {            
            dices.Add(new Dice(color, number));
            return dices;
        }
        
        // Return an empty list of dices
        internal static List<Dice> ClearDices()
        {            
            return new List<Dice>();
        }
        
        // Returns the eyes (int value) of a given dice object
        internal static int GetDiceValue(Dice dice)
        {
            return dice.Eyes;
        }
    }
}