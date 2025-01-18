using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDice
{
    internal class DiceRoller
    {
        private Dice _dice = new Dice();

        // Simulates rolling two dice for a specified number of times
        public int[] SimulateRolls(int numberOfRolls)
        {
            int[] frequencies = new int[13]; // Index 2 to 12 are relevant

            // Based on the number of rolls, two dice will be rolled and the sum will be pushed into the array
            for (int i = 0; i < numberOfRolls; i++)
            {
                int die1 = _dice.Roll();
                int die2 = _dice.Roll();
                int sum = die1 + die2;

                frequencies[sum]++;
            }

            return frequencies;
        }
    }
}
