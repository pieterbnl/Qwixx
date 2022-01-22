using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal class Player    {

        internal string? PlayerName { get; set; }
        internal int PlayerWins { get; set; } = 0;
        internal int PlayerLosses { get; set; } = 0;

        internal int PlayerHighScore { get; set; } = 0;

        internal List<Dice> PlayerHand { get; set; } = new List<Dice>();
    }
}
