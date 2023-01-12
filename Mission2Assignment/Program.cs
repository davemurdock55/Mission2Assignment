// David Murdock
// simulates rolling 2 6d and gives you a histogram of the percentage of each total rolled


using System;

namespace Mission2Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            // initializing the die_total int variable
            int die_total = 0;

            // an array to keep track of the number of times each total number is thrown
            int[] aRollNumTotals = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // Initializing 2 dice objects of the Die class
            Die die1 = new Die();
            Die die2 = new Die();

            // rolling both dice and getting their results
            int die1_result = die1.RollDie();
            int die2_result = die2.RollDie();

            // the die_total is the die_total plus the sum of the rolled results
            die_total += die1_result + die2_result;
            
            // allow the user to choose how many times the 2 dice will be thrown
            // Once teh dice have been throw a certain number of times, print a histogram using the * character
            // that shows the total percentage each number was rolled.
            // each * will represent 1% of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            // Console.Write("How many dice rolls would you like to simulate?");

            // Console.WriteLine("Die 1: " + die1_result);
            // Console.WriteLine("Die 2: " + die2_result);

        }
    }
}


