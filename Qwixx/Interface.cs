using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal static class Interface
    {
        // Displays the (standard) game header
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

        // Displays the game main menu
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
                        Game.InitiateGame();
                        userMenuSelection = null;                        
                        MainMenu();
                        break;

                    case "2": // Show highscores
                        //ShowHighScores();
                        //userMenuSelection = null;                        
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

        // Displays scoreboard of a passed player (object)
        internal static void DrawScoreBoard(Player player)
        {
            // First display the full rows 0 up to and inclusive 3: the scoreboard rows with points + lock                                    
            for (int i = 0; i <= 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(">> ");

                // Set color for number rows
                switch (i)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                }                

                // Iterate through 11 cells
                for (int j = 0; j <= 10; j++)
                {                                 
                    Console.Write("[" + player.Scoreboard.PlayerScoreboard[i, j] + "] "); 
                }
                Console.WriteLine("");
            }

            // Indicate points for crosses
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("Crosses |1x| |2x| |3x| |4x| |5x| |6x| |7x| |8x| |9x| |10x| |11x| |12x|");
            Console.WriteLine("Points  |1 | |3 | |6 | |10| |15| |21| |28| |36| |45| |55 | |66 | |78 |");
            Console.WriteLine();

            // Row 5: the missed throws            
            Console.WriteLine("Each missed throw: -5 points");
            Console.Write("Missed throws: ");
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[4, 0] + "] ");
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[4, 1] + "] ");
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[4, 2] + "] ");
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[4, 3] + "] ");
            Console.WriteLine("\n");

            // Row 6: the end game score values
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Score  ");
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[5, 0] + "]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" + ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[5, 1] + "]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" + ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[5, 2] + "]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" + ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[5, 3] + "]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[5, 4] + "]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" = ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("[" + player.Scoreboard.PlayerScoreboard[5, 5] + "]  ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}