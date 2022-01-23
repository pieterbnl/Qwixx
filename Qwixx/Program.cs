using System;
using System.Text;

namespace Qwixx
{
    public class Program
    {       
        static void Main(string[] args)
        {
            /*Console.WriteLine("PRESS ENTER TO START");
            Console.ReadLine();*/

            // Initiate game by showing it's menu
            //Interfacing.MainMenu();

            // Create dice faces art
            DiceArt.CreateDiceFaces();
                   
            // Add all dices that need to be displayed to an array
            List<StringBuilder[]> DicesThrown = new List<StringBuilder[]>();
            DicesThrown.Add(DiceArt.DICE1);
            DicesThrown.Add(DiceArt.DICE6);
            DicesThrown.Add(DiceArt.DICE3);            

            // Display faces of all dices eyes
            DrawDice.DisplayDices(DicesThrown);
        }      
    }
}