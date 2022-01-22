using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qwixx
{
    internal class Dice
    {
        public string Color { get; set; } = "";
        public int Eyes { get; set; } = 0;

        // Constructor
        public Dice(string Color, int Eyes) 
        {
            this.Color = Color;
            this.Eyes = Eyes;
        }
    }
}
