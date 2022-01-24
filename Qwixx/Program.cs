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
             Interfacing.MainMenu();


            // TEMP STUFF FOR QUICK TESTING
            string userMenuSelection = "";
            Player PlayerOne = new Player("P1");
            Player PlayerTwo = new Player("P2");
            Player PlayerThree = new Player("P3");
            Player PlayerFour = new Player("P4");                       

            // Create a list of players
            List<Player> PlayersUnsorted = new List<Player>();
            PlayersUnsorted.Add(PlayerOne);
            PlayersUnsorted.Add(PlayerTwo);
            PlayersUnsorted.Add(PlayerThree);
            PlayersUnsorted.Add(PlayerFour);





            // Request number of players

            // Create object for each player and request player name

            // Decide playing order by having players throw a dice

            // Register current active player

            // Display current active player + player's score board
            // Request player to throw the dices

            // Display thrown dices + player's score board
            // First, loop past all players, asking them to indicate their action1 (whicte dices), starting with the active player.            
            //
            //      (1) "ACTION1: White dices eyes total X eyes"
            //      "Player X, what's your action?
            //      - No action [N]
            //      - Cross a number [color X] or [cX]"
            //
            //      [CHECK1: In case of no action, move action1 on to next player.
            //      - Register Player X no action on Action1
            //                        
            //      [CHECK2: In case of a number, check if given number is acceptable]
            //      Number in that row can't be checked yet.
            //      Number in that row must be highest check number in that row (i.e. it can't be lower than any other checked number)
            //
            //      [CHECK3: Check if a row is closed]
            //      If the last number has been crossed, and 6 or more numbers are now crossed, the row is closed.
            //
            //      [CHECK3.1: When a row is closed, check if a total of 2 rows have been closed]
            //      If it's the second row being closed, the game will end, after all players have completed their action 1.
            //      In that case indicate coming end:
            //      "Two rows have been closed. After all players have completed their actions, the game ends."
            //
            //      [Repeat action 1 for all players]
            //      
            //      (2) "ACTION2: Player X may now combine one white dice with one colored dice. What's your action?            
            //      - No action [N]
            //      - Cross a number [color X] or [cX]"
            //
            //      [CHECK1: In case of N, check if no action at all has been made]
            //      If no Action1 and no Action2 has been made, the player has a 'failed throw'.
            //      In that casse, add a failed throw.
            //      If it's the 4th failed throw, the game ends.
            //      "Player X has 4th failed throw. The game ends now."
            //      "Press [C] to continue and display the final scores."
            //
            //      [CHECK2: In case of an color + number, check if indicated color + number acceptable]
            //      The number must be any sum of the available white dices + indicated color dice.
            //      Number in that row can't be checked yet.
            //      Number in that row must be highest check number in that row (i.e. it can't be lower than any other checked number)
            //      ?If in action1 a number has been crossed, and in action2 a number in the same row is to be crossed, this combined number may not be higher than action1?
            //
            //      [CHECK3: Check if a row is closed]
            //      If the last number has been crossed, and 6 or more numbers are now crossed, the row is closed.
            //
            //      [CHECK3.1: When a row is closed, check if a total of 2 rows have been closed]
            //      If it's the second row being closed, the game will end now:
            //      "Two rows have been closed. The game ends now."
            //      "Press [C] to continue and display the final scores."
            //
            //      [If the game is not ended, move on to the next player to throw his dices]



            /*
                        // Create dice faces art
                        DiceArt.CreateDiceFaces();

                        // Add all dices that need to be displayed to an array
                        List<StringBuilder[]> DicesThrown = new List<StringBuilder[]>();
                        DicesThrown.Add(DiceArt.DICE1);
                        DicesThrown.Add(DiceArt.DICE6);
                        DicesThrown.Add(DiceArt.DICE3);            

                        // Display faces of all dices eyes
                        DrawDice.DisplayDices(DicesThrown);*/
        }
    }
}