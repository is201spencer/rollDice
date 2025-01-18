using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDice
{
    // This is where the histogram is made
    internal class Histogram
    {
        public void Display(int[] frequencies, int totalRolls)
        {
            Console.WriteLine("\nResults:\n");

            // Calcualtes the percentage into stars for the visual histogram
            for (int sum = 2; sum <= 12; sum++)
            {
                double percentage = (frequencies[sum] / (double)totalRolls) * 100;
                int stars = (int)Math.Round(percentage); // 1% = 1 star

                Console.Write($"{sum}: ");
                Console.WriteLine(new string('*', stars));
            }
        }
    }
}
