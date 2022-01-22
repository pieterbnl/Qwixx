using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal class ThrowDice
    {
        // Throw dice
        // [check which dice are applicable]
        // [generate a random number of eyes for each dice]
        // [create each applicable dice with eyes]

        Dice DiceYellow = new Dice("yellow", 1);
        Dice DiceRed = new Dice("red", 4);
        Dice DiceBlue = new Dice("blue", 3);
        Dice DiceGreen = new Dice("green", 5);
        Dice DiceWhiteOne = new Dice("white", 6);
        Dice DiceWhitewo = new Dice("white", 2);
    }
}
