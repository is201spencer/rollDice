
using rollDice;
//Spencer Wright
internal class Program
{
    private static void Main(string[] args)
    {
        // Ask user how many times they want to roll
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many times do you want to roll: ");
        string rolls = Console.ReadLine();
        int numRolls = int.Parse(rolls);

        // Gets the sum of the two dice rolled
        DiceRoller roller = new DiceRoller();
        int[] results = roller.SimulateRolls(numRolls);

        // Histogram to display results
        Histogram histogram = new Histogram();
        histogram.Display(results, numRolls);
    }
}