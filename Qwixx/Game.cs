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

        internal static List<Player> Players = new List<Player>();                

        // Get input on users
        internal static void RegisterPlayers()
        {
            // Check how many players will play
            while (NumberOfPlayers < 2 || NumberOfPlayers > 5)
            {
                Player player = new Player();
                Console.WriteLine("How many players will play? (2-5)");
                NumberOfPlayers = Convert.ToInt32(Console.ReadLine());
            }

            // Create users
            // CHECK: clumsy, refactor later
            for (int i = 1; i <= NumberOfPlayers; i++)
            {                
                string? PlayerName = "";
                Console.WriteLine("Enter name for Player " + i + ": ");
                PlayerName = Console.ReadLine();

                switch (i) { 

                    case 1:
                        PlayerOne.PlayerName = PlayerName;
                        break;

                    case 2:
                        PlayerTwo.PlayerName = PlayerName;
                        break;

                    case 3:
                        PlayerThree.PlayerName = PlayerName;
                        break;

                    case 4:
                        PlayerFour.PlayerName = PlayerName;
                        break;

                    case 5:
                        PlayerFive.PlayerName = PlayerName;
                        break;

                    default:
                        break;

                }

            }         
        }
        internal static void InitiateGame()
        {
         
        }
    }
}