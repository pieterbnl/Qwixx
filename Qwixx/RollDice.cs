using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal static class RollDice
    {
        // Generate a dice number
        internal static int Roll()
        {
            Random dice = new Random();
            return dice.Next(1, 7);
        }

    }
}
