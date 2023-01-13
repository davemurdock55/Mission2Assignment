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
            Console.Write("\nHow many dice rolls would you like to simulate? ");

            // getting the user input 
            iNumRolls = int.Parse(Console.ReadLine());

            // for every pass, as long as the loop iCount is less than the number of rolls (starting at 0), execute this and then add 1
            for (int iCount = 0; iCount < iNumRolls; iCount++)
            {
                // resetting the dice total to 0 each loop, just in case...
                diceTotal = 0;

                // rolling both dice and getting their results
                int die1Result = die1.RollDie();
                int die2Result = die2.RollDie();

                // printing the dice roll results
                // Console.WriteLine("Die 1: " + die1Result);
                // Console.WriteLine("Die 2: " + die2Result);

                // the diceTotal is the diceTotal plus the sum of the rolled results
                diceTotal = die1Result + die2Result;

                // printing the totaled roll results for this pass
                // Console.WriteLine("Total: " + diceTotal);

                // a switch statement that adds the diceTotal to the array position corresponding with that dice total
                // (E.g. If you got a 2 for your roll, case 2 is executed and your diceTotal is added to the current number in position 2 of the array)
                switch(diceTotal)
                {
                    case 2:
                        aRollNumTotals[0]++;
                        break;
                    case 3:
                        aRollNumTotals[1]++;
                        break;
                    case 4:
                        aRollNumTotals[2]++;
                        break;
                    case 5:
                        aRollNumTotals[3]++;
                        break;
                    case 6:
                        aRollNumTotals[4]++;
                        break;
                    case 7:
                        aRollNumTotals[5]++;
                        break;
                    case 8:
                        aRollNumTotals[6]++;
                        break;
                    case 9:
                        aRollNumTotals[7]++;
                        break;
                    case 10:
                        aRollNumTotals[8]++;
                        break;
                    case 11:
                        aRollNumTotals[9]++;
                        break;
                    case 12:
                        aRollNumTotals[10]++;
                        break;
                }
            }


            // printing those to test them
            /* for (int iCount = 0; iCount < aRollNumTotals.Length; iCount++)
            {
                Console.WriteLine((iCount + 2) + ": " + aRollNumTotals[iCount]);
            } */

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + iNumRolls + ".");


            for (int iCount = 0; iCount < aRollNumTotals.Length; iCount++)
            {
                Console.Write((iCount + 2) + ": ");
                float fRollPercentage = (float)aRollNumTotals[iCount] / (float)iNumRolls;
                // I think I can just let the system handle this rounding

                int iNumAsterisks = (int)(fRollPercentage * 100);

                // Console.Write("Roll percentage: " + fRollPercentage + "    ");
                // Console.Write("*: " + iNumAsterisks + "    ");
                for (int iAsteriskCount = 0; iAsteriskCount < iNumAsterisks; iAsteriskCount++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            // Telling the user goodbye! :)
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}


