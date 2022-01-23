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
            "└─────────┘"));           

            // Add dices eyes that need to be displayed to array
            List<int> dices = new List<int>();
            dices.Add(1);
            dices.Add(6);
            dices.Add(3);
            dices.Add(1);
            dices.Add(2);
            dices.Add(3);

            // Display faces of all dices eyes
            DisplayDices(dices);
        }

        // Display faces of all passed dices eyes
        internal static void DisplayDices(List<int> dices)
        {
            string[] DiceFacesOutput = new string[5];            
            int line = 0;

            // Loop through all eyes (key values: 1 & 3)
            foreach (int dice in dices)
            {
                /*Console.WriteLine("Processing dice: " + dice + " ->> ");                
                Console.WriteLine(DICE_ART[dice]); // prints complete dice face
                Console.WriteLine();*/

                // Split the dice face into lines, into an array                
                string[] DiceFaceLines = DICE_ART[dice].ToString().Split("\n");
                foreach (string s in DiceFaceLines)
                {
                    DiceFacesOutput[line] = DiceFacesOutput[line] + s + "   ";
                    /*Console.WriteLine(DiceFacesOutput[line]);*/
                    line += 1;
                }
                line = 0;
            }

            // Loop through DiceFacesOutput
            foreach (string s in DiceFacesOutput)
            {                                
                Console.WriteLine(s);
            }
        }
    }
}




/*foreach (KeyValuePair<int, StringBuilder> dice in DICE_ART)
{
    //Console.WriteLine("{0}, {1}", dice.Key, dice.Value);
    Console.WriteLine(dice.Value);
}*/

/*
            // Add all dice faces to an array
            StringBuilder[] DiceFaces = { DiceFace1, DiceFace2, DiceFace3, DiceFace4, DiceFace5, DiceFace6 };
            string[] DiceFacesOutput;

            // Combine faces from all rolled dices faces

            string[] DiceFaceLines = DiceFace3.ToString().Split("\\n");
            Console.WriteLine("Content = ");
            int i = 0;
            foreach (string s in DiceFaceLines)
            {
                // i+=1;
                // Console.WriteLine("i: " + i);
                Console.WriteLine(s);
            }


            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }



            *//*  Console.Write(Dice1);
              Console.WriteLine();
              Console.Write(Dice2);
              Console.WriteLine();
              Console.WriteLine(Dice3);*//*
            Console.WriteLine();

            *//*StringBuilder Dices = new StringBuilder();          
            Dices.Append(Dice1);
            Dices.Append(Dice2);
            Dices.Append(Dice3);
            Console.WriteLine(Dices);*/