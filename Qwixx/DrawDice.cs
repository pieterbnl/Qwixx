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

        internal static void GenerateDiceFaces()
        {
            // Create faces for all dice eyes
            StringBuilder Dice1 = new StringBuilder(
           "┌─────────┐\\n" +
           "│         │\\n" +
           "│    0    │\\n" +
           "│         │\\n" +
           "└─────────┘");

            StringBuilder Dice2 = new StringBuilder(
           "┌─────────┐\\n" +
           "│  0      │\\n" +
           "│         │\\n" +
           "│      0  │\\n" +
           "└─────────┘");

            StringBuilder Dice3 = new StringBuilder(
            "┌─────────┐\\n" +
            "│  0      │\\n" +
            "│    0    │\\n" +
            "│      0  │\\n" +
            "└─────────┘");

            StringBuilder Dice4 = new StringBuilder(
            "┌─────────┐\\n" +
            "│  0   0  │\\n" +
            "│         │\\n" +
            "│  0   0  │\\n" +
            "└─────────┘");

            StringBuilder Dice5 = new StringBuilder(
            "┌─────────┐\\n" +
            "│  0   0  │\\n" +
            "│    0    │\\n" +
            "│  0   0  │\\n" +
            "└─────────┘");

            StringBuilder Dice6 = new StringBuilder(
            "┌─────────┐\\n" +
            "│  0   0  │\\n" +
            "│  0   0  │\\n" +
            "│  0   0  │\\n" +
            "└─────────┘");

            // Add all dice faces to an array
            StringBuilder[] Dices = { Dice1, Dice2, Dice3, Dice4, Dice5, Dice6 };
        }
/*
        internal static StringBuilder GetDiceFaces(int[] DiceValues)
        {

*//*

            const string[] DICE_ART =


            string[] DiceFaces;
            foreach (int value in DiceValues)
            {
                DiceFaces.Append(DICE_ART[value]);
            }


            return DiceFace;*//*
        }
*/
    }
}