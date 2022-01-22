using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal static class Game
    {
        internal static int NumberOfPlayers = 0;

        // CHECK: dynamically creation of objects
        internal static Player PlayerOne = new Player();
        internal static Player PlayerTwo = new Player();
        internal static Player PlayerThree = new Player();
        internal static Player PlayerFour = new Player();
        internal static Player PlayerFive = new Player();                

        internal static List<Player> PlayersUnordered = new List<Player>();
        internal static List<Player> PlayersOrdered = new List<Player>();

        // Get input on users
        internal static void RegisterPlayers()
        {
            // Clear header
            Interfacing.Header();

            // Check how many players will play
            while (NumberOfPlayers < 2 || NumberOfPlayers > 5)
            {
                Player player = new Player();
                Console.WriteLine("How many players will play? (2-5)");
                NumberOfPlayers = Convert.ToInt32(Console.ReadLine());
            }

            // Clear header again and display number of players
            Interfacing.Header();
            Console.WriteLine(NumberOfPlayers + " players will play.\n");

            // Create users
            // CHECK: clumsy, refactor later
            for (int i = 1; i <= NumberOfPlayers; i++)
            {                
                string? PlayerName = ""; // CHECK
                Console.Write("Enter name for Player " + i + ": ");
                PlayerName = Console.ReadLine();
                Console.WriteLine();

                switch (i) { 
                    case 1:
                        PlayerOne.PlayerName = PlayerName.ToUpper();
                        PlayersUnordered.Add(PlayerOne);
                        break;

                    case 2:
                        PlayerTwo.PlayerName = PlayerName.ToUpper();
                        PlayersUnordered.Add(PlayerTwo);
                        break;

                    case 3:
                        PlayerThree.PlayerName = PlayerName.ToUpper();
                        PlayersUnordered.Add(PlayerThree);
                        break;

                    case 4:
                        PlayerFour.PlayerName = PlayerName.ToUpper();
                        PlayersUnordered.Add(PlayerFour);
                        break;

                    case 5:
                        PlayerFive.PlayerName = PlayerName.ToUpper();
                        PlayersUnordered.Add(PlayerFive);
                        break;

                    default:
                        break;
                }
            }         
        }
        internal static void InitiateGame()
        {
            // Clear header
            Interfacing.Header();

            // show game is starting
            Console.WriteLine("All players are created. Each player will now roll a dice.");
            Console.WriteLine("Playing order will be in order of the rolled eyes.\n");

            List<int> PlayerRollScores = new List<int>();

            foreach (Player Player in PlayersUnordered.Take(NumberOfPlayers))
            {                
                while (Console.ReadLine() != "T")
                {                    
                    Console.WriteLine(Player.PlayerName + "! Ready to roll your dice? Press [T] to roll!");
                    PlayerRollScores.Add(RollDice.Roll());
                    Console.WriteLine(Player.PlayerName + " rolls " + PlayerRollScores);
                }                
            }
        }
    }
}