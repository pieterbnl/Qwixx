using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal static class DiceArt
    {
        internal static StringBuilder[] DICE1 = new StringBuilder[6];
        internal static StringBuilder[] DICE2 = new StringBuilder[6];
        internal static StringBuilder[] DICE3 = new StringBuilder[6];
        internal static StringBuilder[] DICE4 = new StringBuilder[6];
        internal static StringBuilder[] DICE5 = new StringBuilder[6];
        internal static StringBuilder[] DICE6 = new StringBuilder[6];

        internal static void CreateDiceFaces()
        {
            // Create faces for all dice eyes            
            DICE1[0] = new StringBuilder("┌─────────┐");
            DICE1[1] = new StringBuilder("│         │");
            DICE1[2] = new StringBuilder("│    0    │");
            DICE1[3] = new StringBuilder("│         │");
            DICE1[4] = new StringBuilder("└─────────┘");
            DICE1[5] = new StringBuilder("white");
                        
            DICE2[0] = new StringBuilder("┌─────────┐");
            DICE2[1] = new StringBuilder("│  0      │");
            DICE2[2] = new StringBuilder("│         │");
            DICE2[3] = new StringBuilder("│      0  │");
            DICE2[4] = new StringBuilder("└─────────┘");
            DICE2[5] = new StringBuilder("white");
                        
            DICE3[0] = new StringBuilder("┌─────────┐");
            DICE3[1] = new StringBuilder("│  0      │");
            DICE3[2] = new StringBuilder("│    0    │");
            DICE3[3] = new StringBuilder("│      0  │");
            DICE3[4] = new StringBuilder("└─────────┘");
            DICE3[5] = new StringBuilder("white");

            DICE4[0] = new StringBuilder("┌─────────┐");
            DICE4[1] = new StringBuilder("│  0   0  │");
            DICE4[2] = new StringBuilder("│         │");
            DICE4[3] = new StringBuilder("│  0   0  │");
            DICE4[4] = new StringBuilder("└─────────┘");
            DICE4[5] = new StringBuilder("white");

            DICE5[0] = new StringBuilder("┌─────────┐");
            DICE5[1] = new StringBuilder("│  0   0  │");
            DICE5[2] = new StringBuilder("│    0    │");
            DICE5[3] = new StringBuilder("│  0   0  │");
            DICE5[4] = new StringBuilder("└─────────┘");
            DICE5[5] = new StringBuilder("white");

            DICE6[0] = new StringBuilder("┌─────────┐");
            DICE6[1] = new StringBuilder("│  0   0  │");
            DICE6[2] = new StringBuilder("│  0   0  │");
            DICE6[3] = new StringBuilder("│  0   0  │");
            DICE6[4] = new StringBuilder("└─────────┘");
            DICE6[5] = new StringBuilder("white");
        }
    }
}