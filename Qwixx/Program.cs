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



          /*  string Dice =
           "┌─────────┐" +
           "│         │" +
           "│    ●    │" +
           "│         │" +
           "└─────────┘";*/


            StringBuilder Dice1 = new StringBuilder(
            @"
           ┌─────────┐
           │         │
           │    0    │
           │         │
           └─────────┘");

            StringBuilder Dice2 = new StringBuilder(
            @"
           ┌─────────┐
           │         │
           │   0  0  │
           │         │
           └─────────┘");


            StringBuilder Dice3 = new StringBuilder(
            "┌─────────┐\\n" +
           "│    0    │\\n" +
           "│    0    │\\n" +
           "│    0    │\\n" +
           "└─────────┘");

          /*  Console.Write(Dice1);
            Console.WriteLine();
            Console.Write(Dice2);
            Console.WriteLine();
            Console.WriteLine(Dice3);*/
            Console.WriteLine();

            /*StringBuilder Dices = new StringBuilder();          
            Dices.Append(Dice1);
            Dices.Append(Dice2);
            Dices.Append(Dice3);
            Console.WriteLine(Dices);*/

            string[] lines = Dice3.ToString().Split("\\n");
            Console.WriteLine("Content = ");
            int i = 0;
            foreach (string s in lines)
            {
                i+=1;
                Console.WriteLine("i: " + i);
                Console.WriteLine(s);
            }
        }
    }
}