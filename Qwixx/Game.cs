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

        internal static bool GameActive = true; // tracks if a game is 'active' (true) or ended (false)

        // CHECK: dynamically creation of objects
        internal static Player PlayerOne = new Player();
        internal static Player PlayerTwo = new Player();
        internal static Player PlayerThree = new Player();
        internal static Player PlayerFour = new Player();
        internal static Player PlayerFive = new Player();

        static string userMenuSelection = ""; // for receiving a user's menu selection
        static internal List<Dice> InGameDices { get; set; } = new List<Dice>(); // holds all active dices in the game

        internal static List<Player> PlayersUnsorted = new List<Player>(); // holds list of newly created players, in order of player creation
        internal static List<Player> PlayersSorted = new List<Player>(); // holds list of players, in playing order after having rolled a dice

        // Clear's all game values, to start a new game
        internal static void ClearGame()
        {
            NumberOfPlayers = 0;
            ActivePlayer = 0;
            InGameDices = Dice.ClearDices(); // returns an empty list with no dices
            PlayersUnsorted.Clear(); // REFACTOR - create method to clear
        }

        // Initiate game
        internal static void InitiateGame()
        {
            // Clear any values of a possible previous game
            ClearGame();

            // Check which users will participate and register them
            Game.RegisterPlayers();

            // Create dice faces art
            DiceArt.CreateDiceFaces();

            // Add dices to game
            InGameDices = Dice.AddDicesToGame(InGameDices);

            // Decide playing order, by rolling dices
            Game.SetPlayingOrder();

            // Display playing order, after having rolled dices
            Game.DisplayPlayingOrder();

            // Start game and display the first player's action and scoreboard
            Game.PlayGame();
        }

        // Set players
        internal static void RegisterPlayers()
        {
            // Start with a clean header
            Interface.Header();

            // Check how many players will play
            while (NumberOfPlayers < 2 || NumberOfPlayers > 5)
            {
                Player player = new Player();
                Console.WriteLine("How many players will play? (2-5)");
                NumberOfPlayers = Convert.ToInt32(Console.ReadLine());
            }

            // Clear header again and display number of players
            Interface.Header();
            Console.WriteLine(NumberOfPlayers + " players will play.\n");

            // Confirm names of each player
            // Add a player object for each player to a PlayersUnsorted list
            // CHECK: clumsy, refactor later
            for (int i = 1; i <= NumberOfPlayers; i++)
            {                
                Console.Write("Enter name for Player " + i + ": ");
                string? PlayerName = Console.ReadLine();
                Console.WriteLine();

                switch (i)
                {
                    case 1:                        
                        PlayersUnsorted.Add(PlayerOne = new Player(PlayerName.ToUpper()));
                        break;

                    case 2:                        
                        PlayersUnsorted.Add(PlayerTwo = new Player(PlayerName.ToUpper()));
                        break;

                    case 3:                        
                        PlayersUnsorted.Add(PlayerThree = new Player(PlayerName.ToUpper()));
                        break;

                    case 4:                        
                        PlayersUnsorted.Add(PlayerFour = new Player(PlayerName.ToUpper()));
                        break;

                    case 5:                       
                        PlayersUnsorted.Add(PlayerFive = new Player(PlayerName.ToUpper()));
                        break;

                    default:
                        break;
                }
            }
        }

        // Set playing order of players
        internal static void SetPlayingOrder()
        {           
            // Show game is starting
            Console.WriteLine("All players are created. Each player will now roll a dice.");
            Console.WriteLine("Playing order will be in order of the rolled eyes.\n");

            // Iterate through all player objects in unsorted player list            
            foreach (Player player in PlayersUnsorted)
            {
                // Make sure to clear player's hand: containing no dices
                player.PlayerHandDices = Dice.ClearDices();

                // Clear header
                Interface.Header();              

                // Make selected player roll a dice
                while (userMenuSelection != "R")
                {
                    Console.WriteLine(player.PlayerName + "! Ready to roll a dice? Press [R] to roll!");                    
                    userMenuSelection = Console.ReadLine().ToUpper();
                }

                // Add a white dice to the player's hand
                player.PlayerHandDices = Dice.AddADice("white", 1, player.PlayerHandDices);

                // Roll the player's dice
                player.PlayerHandDices = Dice.RollADiceInAHand(player.PlayerHandDices, 0);

                // Clear header again and state rolled eyes                
                // Display the rolled dice by feeding DisplayDices method with the player's hand 
                Interface.Header();
                Console.WriteLine(player.PlayerName + " rolls... ");
                              
                // Convert rolled dice value in player's hand to respective Dice art
                Dice.DisplayDices(Dice.ConvertDiceToDiceArt(player.PlayerHandDices));             

                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
                userMenuSelection = "";
            }           
        }

        // Displaying the player's playing order
        internal static void DisplayPlayingOrder()
        {
            // Clear header
            Interface.Header();

            // Sort players playing order, based on rolled dice eyes
            // CHECK: not using PlayerDiceValue to retrieve eyes from rolled dice
            PlayersSorted = PlayersUnsorted.OrderByDescending(o => o.PlayerHandDices[0].Eyes).ToList();

            // Display playing order
            Console.WriteLine("All players have rolled a dice. Playing order will be as following: \n");

            int count = 1;
            foreach (Player player in PlayersSorted)
            {
                Console.WriteLine(count + ". " + player.PlayerName + " (rolled " + player.PlayerHandDices[0].Eyes +")");
                count++;
            }

            Console.WriteLine("\nPress ENTER to start the game.");
            Console.ReadLine();
        }

        // Start of the actual game
        internal static void PlayGame()
        {
            // Display current active player + player's score board
            // Request player to throw the dices

            // Prepare initial (empty) scoreboard for each player
            foreach (Player player in PlayersSorted)
            {
                player.Scoreboard.InitiateScoreboard();
            }

            // Keep iterating game rounds, while game is 'active' (i.e. no game ending conditions have emerged yet)
            while (GameActive)
            {
                foreach (Player player in PlayersSorted)
                {
                    // Clear header
                    Interface.Header();

                    // Indicate active player
                    Console.WriteLine("It's " + player.PlayerName + "'s turn.\n");
                    Console.WriteLine(player.PlayerName + "SCOREBOARD\n");

                    // Display player's scoreboard
                    Interface.DrawScoreBoard(player);
                    Console.WriteLine();

                    Console.WriteLine(player.PlayerName + " throws his dices.. ");
                    Thread.Sleep(100);


                    // KEEP TRACK OF INGAME DICES
                    // HAVE ALL ACTIVE DICES ADDED TO PLAYERS HAND
                    // MAKE PLAYER THROW DICES

                    Console.ReadLine();
                }
            }
        }       
    }
}