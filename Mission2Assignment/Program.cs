// David Murdock
// simulates rolling 2 6d and gives you a histogram of the percentage of each total rolled


using System;

namespace Mission2Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {


            // an array to keep track of the number of times each total number is thrown
            int[] aRollNumTotals = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // Initializing 2 die objects of the Die class
            Die dice1 = new Die();
            Die dice2 = new Die();

            int die1_result = dice1.RollDie();
            int die2_result = dice2.RollDie();
            

            // allow the user to choose how many times the 2 dice will be thrown
            // Once teh dice have been throw a certain number of times, print a histogram using the * character
            // that shows the total percentage each number was rolled.
            // each * will represent 1% of rolls
            Console.WriteLine("Welcome to the dice throwing simulator!");
            // Console.Write("How many dice rolls would you like to simulate?");

            Console.WriteLine("Die 1: " + die1_result);
            Console.WriteLine("Die 2: " + die2_result);

        }
    }
}


