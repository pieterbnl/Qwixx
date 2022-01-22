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
    }
}