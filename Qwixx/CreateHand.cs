using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal class CreatePlayerHand
    {

        // Create player hand
        List<Dice> PlayerHand = new List<Dice>();

       

        
        void CreateHand()
        {
            PlayerHand.Add(DiceYellow);
            PlayerHand.Add(DiceRed);
            PlayerHand.Add(DiceWhiteOne);
        }

    }
}
