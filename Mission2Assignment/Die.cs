using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2Assignment
{
    public class Die
    {
        public int RollDie()
        {
            // creating a new "Random" object
            Random rnd = new Random();
            // generates a + random int within the sepecified range (includes min, excludes max)
            int numRolled = rnd.Next(1, 7);

            return numRolled;
        }
    }
}
