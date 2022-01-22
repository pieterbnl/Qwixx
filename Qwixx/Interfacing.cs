using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal static class Interfacing
    {      
        internal static void MainMenu()
        {
            string? userMenuSelection = null;
            while ((userMenuSelection != "1") && (userMenuSelection != "2") && (userMenuSelection != "3"))
            {
                Header();
                Console.WriteLine("1. Start a new game");
                Console.WriteLine("2. Show high scores");
                Console.WriteLine("3. Exit");
                Console.Write("\r\nSelect an option: ");
                userMenuSelection = Console.ReadLine().ToUpper();

                switch (userMenuSelection)
                {
                    case "1": // Start game
                        Game.RegisterPlayers();
                        Game.InitiateGame();
                        userMenuSelection = null;
                        Header();
                        MainMenu();
                        break;

                    case "2": // Show highscores
                        //ShowHighScores();
                        //userMenuSelection = null;
                        Header();
                        MainMenu();
                        break;

                    case "3": // Exit program
                        Header();
                        Console.WriteLine("See you next time! Exiting...");
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;

                    default: // Invalid choice
                        break;
                }
            }
        }

        internal static void Header()
        {
            // Clear the console
            Console.Clear();

            // Draw program header
            Console.WriteLine("*******");
            Console.WriteLine("*QWIXX*");
            Console.WriteLine("*******");
            Console.WriteLine();
        }
    }
}