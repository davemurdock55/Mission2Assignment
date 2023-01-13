// David Murdock
// simulates rolling 2 6d and gives you a histogram of the percentage of each total rolled


using System;

namespace Mission2Assignment
{
    class Program
    {
        // Overall Instructions:
        // allow the user to choose how many times the 2 dice will be thrown
        // Once the dice have been throw a certain number of times, print a histogram using the * character
        // that shows the total percentage each number was rolled.
        // each * will represent 1% of rolls

        public static void Main(string[] args)
        {
            // initializing the die_total int variable
            int diceTotal = 0;
            int iNumRolls = 0;

            // an array to keep track of the number of times each total number is thrown
            int[] aRollNumTotals = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // Initializing 2 dice objects of the Die class
            Die die1 = new Die();
            Die die2 = new Die();



            // Welcoming the User
            Console.WriteLine("Welcome to the dice throwing simulator!");

            // Asking the user how many times they want to throw the two dice
            Console.Write("How many dice rolls would you like to simulate?");

            // getting the user input 
            iNumRolls = int.Parse(Console.ReadLine());

            // rolling both dice and getting their results
            int die1Result = die1.RollDie();
            int die2Result = die2.RollDie();

            // the die_total is the die_total plus the sum of the rolled results
            diceTotal += die1Result + die2Result;
            
            

            // Console.WriteLine("Die 1: " + die1_result);
            // Console.WriteLine("Die 2: " + die2_result);

        }
    }
}


