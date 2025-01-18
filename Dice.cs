using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDice
    // Generates random number between 1 and 6 on die
{
    internal class Dice
    {
        private Random r = new Random();

        public int Roll()
        {
            return r.Next(1, 7);
        }
    }
}
