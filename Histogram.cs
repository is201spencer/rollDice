using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDice
{
    internal class Histogram
    {
        public void Display(int[] frequencies, int totalRolls)
        {
            Console.WriteLine("\nResults:");

            for (int sum = 2; sum <= 12; sum++)
            {
                double percentage = (frequencies[sum] / (double)totalRolls) * 100;
                int stars = (int)Math.Round(percentage); // 1% = 1 star

                Console.Write($"{sum}: {frequencies[sum],5} ({percentage,5:F1}%): ");
                Console.WriteLine(new string('*', stars));
            }
        }
    }
}
