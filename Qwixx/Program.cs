using System;
using System.Text;

namespace Qwixx
{
    public class Program
    {       
        static IDictionary<int, StringBuilder> DICE_ART = new Dictionary<int, StringBuilder>();      

        static void Main(string[] args)
        {
            /*Console.WriteLine("PRESS ENTER TO START");
            Console.ReadLine();*/

            // Initiate game by showing it's menu
            //Interfacing.MainMenu();

            // Create faces for all dice eyes
            StringBuilder[] DICE1 = new StringBuilder[6];
            DICE1[0] = new StringBuilder("┌─────────┐");
            DICE1[1] = new StringBuilder("│         │");
            DICE1[2] = new StringBuilder("│    0    │");
            DICE1[3] = new StringBuilder("│         │");
            DICE1[4] = new StringBuilder("└─────────┘");
            DICE1[5] = new StringBuilder("white");

            StringBuilder[] DICE2 = new StringBuilder[6];
            DICE2[0] = new StringBuilder("┌─────────┐");
            DICE2[1] = new StringBuilder("│  0      │");
            DICE2[2] = new StringBuilder("│         │");
            DICE2[3] = new StringBuilder("│      0  │");
            DICE2[4] = new StringBuilder("└─────────┘");
            DICE2[5] = new StringBuilder("yellow");

            StringBuilder[] DICE3 = new StringBuilder[6];
            DICE3[0] = new StringBuilder("┌─────────┐");
            DICE3[1] = new StringBuilder("│  0      │");
            DICE3[2] = new StringBuilder("│    0    │");
            DICE3[3] = new StringBuilder("│      0  │");
            DICE3[4] = new StringBuilder("└─────────┘");
            DICE3[5] = new StringBuilder("blue");

            StringBuilder[] DICE4 = new StringBuilder[6];
            DICE4[0] = new StringBuilder("┌─────────┐");
            DICE4[1] = new StringBuilder("│  0   0  │");
            DICE4[2] = new StringBuilder("│         │");
            DICE4[3] = new StringBuilder("│  0   0  │");
            DICE4[4] = new StringBuilder("└─────────┘");

            StringBuilder[] DICE5 = new StringBuilder[6];
            DICE5[0] = new StringBuilder("┌─────────┐");
            DICE5[1] = new StringBuilder("│  0   0  │");
            DICE5[2] = new StringBuilder("│    0    │");
            DICE5[3] = new StringBuilder("│  0   0  │");
            DICE5[4] = new StringBuilder("└─────────┘");
            DICE5[5] = new StringBuilder("white");

            StringBuilder[] DICE6 = new StringBuilder[6];
            DICE6[0] = new StringBuilder("┌─────────┐");
            DICE6[1] = new StringBuilder("│  0   0  │");
            DICE6[2] = new StringBuilder("│  0   0  │");
            DICE6[3] = new StringBuilder("│  0   0  │");
            DICE6[4] = new StringBuilder("└─────────┘");
            DICE6[5] = new StringBuilder("red");

            // Add all dices that need to be displayed to an array
            List<StringBuilder[]> DicesThrown = new List<StringBuilder[]>();
            DicesThrown.Add(DICE2);
            DicesThrown.Add(DICE6);
            DicesThrown.Add(DICE3);
                   
            // Display faces of all dices eyes
            DisplayDices(DicesThrown);
        }

        // Display faces of all passed dices eyes
        internal static void DisplayDices(List<StringBuilder[]> DicesThrown)
        {
            // Loop trough all (5) lines that make up a dice face
            for (int line = 0; line <= 4; line++)
            {
                // Loop through each thrown dice
                foreach (StringBuilder[] dice in DicesThrown)
                {
                    // Check the dice color and set the console display accordingly
                    switch (dice[5].ToString())
                    {
                        case "yellow":
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case "red":
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case "blue":
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                    }

                    // Write line from dice, including some white space
                    Console.Write(dice[line]);
                    Console.Write("    ");

                }
                // Break line, as now all thrown dices are looped
                // and a full dice face line has been completed
                Console.WriteLine();
            }
        }
          
    }
}



/*
DICE_ART.Add(1,
new StringBuilder(
"┌─────────┐\n" +
"│         │\n" +
"│    0    │\n" +
"│         │\n" +
"└─────────┘"));

DICE_ART.Add(2,
new StringBuilder(
"┌─────────┐\n" +
"│  0      │\n" +
"│         │\n" +
"│      0  │\n" +
"└─────────┘"));

DICE_ART.Add(3,
new StringBuilder(
"┌────X────┐\n" +
"│  0      │\n" +
"│    0    │\n" +
"│      0  │\n" +
"└─────────┘"));

DICE_ART.Add(4,
new StringBuilder(
"┌─────────┐\n" +
"│  0   0  │\n" +
"│         │\n" +
"│  0   0  │\n" +
"└─────────┘"));

DICE_ART.Add(5,
new StringBuilder(
"┌─────────┐\n" +
"│  0   0  │\n" +
"│    0    │\n" +
"│  0   0  │\n" +
"└─────────┘"));

DICE_ART.Add(6,
new StringBuilder(
"┌─────────┐\n" +
"│  0   0  │\n" +
"│  0   0  │\n" +
"│  0   0  │\n" +
"└─────────┘"));*/


/*internal static void DisplayDices(List<int> dices)
{
    string[] DiceFacesOutput = new string[5];
    int line = 0;

    // Loop through all eyes (key values: 1 & 3)
    foreach (int dice in dices)
    {
        // Split the dice face into lines, into an array                
        string[] DiceFaceLines = DICE_ART[dice].ToString().Split("\n");
        foreach (string s in DiceFaceLines)
        {
            //DiceFacesOutput[line] = DiceFacesOutput[line] + s + "   ";

            switch (dice)
            {
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.Write(s);
            //Console.WriteLine();
            line += 1;
        }
        line = 0;
    }

    // Loop through DiceFacesOutput
    foreach (string s in DiceFacesOutput)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(s);
        Console.ForegroundColor = ConsoleColor.Black;
    }*/



/*// Loop through all eyes (key values: 1 & 3)
foreach (int dice in dices)
{
    // Split the dice face into lines, into an array                
    string[] DiceFaceLines = DICE_ART[dice].ToString().Split("\n");
    foreach (string s in DiceFaceLines)
    {
        DiceFacesOutput[line] = DiceFacesOutput[line] + s + "   ";
        Console.WriteLine(DiceFacesOutput[line]);
        line += 1;
    }
    line = 0;
}

// Loop through DiceFacesOutput
foreach (string s in DiceFacesOutput)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(s);
    Console.ForegroundColor = ConsoleColor.Black;
}*/