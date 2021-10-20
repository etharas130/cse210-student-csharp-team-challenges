using System;
// using System.Collections.Generic;

namespace _06_mastermind
{
    // This class generates a random 4 digit number 
    // and takes the guess from the player 
    // and compares the two adn returns a hint in the form of a string
    class Compare
    {
        int _number;

        // generates a random number 
        private void GenerateNumber()
        {
            Random RandomGenerator = new Random();
            _number = RandomGenerator.Next(1000,10000);
        }
        
        // compares the player's guess to the random number 
        // and retnurns a complicated hint :) 
        public string CompareGuess(string guess)
        {
            string hint = "****";
            string number = _number.ToString();

            return hint;
        }
    }
}