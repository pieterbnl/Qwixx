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
        internal static int ActivePlayer = 0;

        // CHECK: dynamically creation of objects
        internal static Player PlayerOne = new Player();
        internal static Player PlayerTwo = new Player();
        internal static Player PlayerThree = new Player();
        internal static Player PlayerFour = new Player();
        internal static Player PlayerFive = new Player();

        static string userMenuSelection = "";

        internal static List<StringBuilder[]> DicesThrown = new List<StringBuilder[]>();

        internal static List<Player> PlayersUnsorted = new List<Player>();

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
                        PlayersUnsorted.Add(PlayerOne);
                        //PlayersUnsorted.Add(PlayerOne = new Player(PlayerName.ToUpper()));
                        break;

                    case 2:
                        PlayerTwo.PlayerName = PlayerName.ToUpper();
                        PlayersUnsorted.Add(PlayerTwo);
                        break;

                    case 3:
                        PlayerThree.PlayerName = PlayerName.ToUpper();
                        PlayersUnsorted.Add(PlayerThree);
                        break;

                    case 4:
                        PlayerFour.PlayerName = PlayerName.ToUpper();
                        PlayersUnsorted.Add(PlayerFour);
                        break;

                    case 5:
                        PlayerFive.PlayerName = PlayerName.ToUpper();
                        PlayersUnsorted.Add(PlayerFive);
                        break;

                    default:
                        break;
                }
            }
        }
        internal static void InitiateGame()
        {
            // Create dice faces art
            DiceArt.CreateDiceFaces();

            // Decide playing order
            Game.SetPlayingOrder();
        }

        internal static void SetPlayingOrder()
        {           
            // Show game is starting
            Console.WriteLine("All players are created. Each player will now roll a dice.");
            Console.WriteLine("Playing order will be in order of the rolled eyes.\n");

            // Iterate through all player objects in unsorted player list
            foreach (Player player in PlayersUnsorted)
            {
                // Make sure to clear player's hand: containing no dices
                player.ClearPlayerHand();

                // Clear header
                Interfacing.Header();              

                // Make selected player roll a dice
                while (userMenuSelection != "R")
                {
                    Console.WriteLine(player.PlayerName + "! Ready to roll a dice? Press [R] to roll!");                    
                    userMenuSelection = Console.ReadLine().ToUpper();
                }

                // Roll a dice and add rolled dice to playerhand
                player.AddDiceToPlayerHand("white", RollDice.Roll());

                // Clear header again and state rolled eyes                
                // Display the rolled dice by feeding DisplayDices method with the player's hand 
                Interfacing.Header();
                Console.WriteLine(player.PlayerName + " rolls... ");                                
                DrawDice.DisplayDices(player.ConvertDiceToDiceArt(player.PlayerHand));                
                Console.WriteLine("Press a key to continue.");
                Console.ReadLine();
                userMenuSelection = "";
            }

            // Sort players playing order, based on rolled dice eyes
            // CHECK: not using PlayerDiceValue to retrieve eyes from rolled dice
            List<Player> PlayersSorted = PlayersUnsorted.OrderByDescending(o => o.PlayerHand[0].Eyes).ToList();

            // Display playing order
            Console.WriteLine("Playing order will be as following. Press a key to continue.");
            foreach (Player player in PlayersSorted)
            {
                Console.WriteLine(player.PlayerName + ": " + player.PlayerDiceValue(0));
            }
            Console.ReadLine();
        }

        // Clear's all game values, to start a new game
        internal static void ClearGame()
        {
            NumberOfPlayers = 0;
            ActivePlayer = 0;
            DicesThrown.Clear();
            PlayersUnsorted.Clear();
        }
    }
}