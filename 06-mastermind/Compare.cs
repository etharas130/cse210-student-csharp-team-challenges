using System;
// using System.Collections.Generic;

namespace _06_mastermind
{
    // This class generates a random 4 digit number 
    // and takes the guess from the player 
    // and compares the two and returns a hint in the form of a string
    class Compare
    {
        private int _number;

        // generates a random number 
        public int GenerateNumber()
        {
            Random RandomGenerator = new Random();
            _number = RandomGenerator.Next(1000,10000);
            return _number;
        }

        public int GetNumber()
        {
            return _number;
        }
        
        // compares the player's guess to the random number 
        // and returns a complicated hint :) 
        public string CompareGuess(string guess, int rNumber)
        {
            string hint = "";
            string number = rNumber.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                if(guess[0] == number[i] && i == 0)
                {
                    hint += guess[0];
                }
                else if(guess[1] == number[i] && i == 1)
                {
                    hint += guess[1];
                }
                else if(guess[2] == number[i] && i == 2)
                {
                    hint += guess[2];
                }
                else if(guess[3] == number[i] && i == 3)
                {
                    hint += guess[3];
                }
                else if(guess[0] == number[i] || guess[1] == number[i] || guess[2] == number[i] || guess[3] == number[i])
                {
                    hint += "o";
                }
                else 
                {
                    hint += "x";
                }
            }
            return hint;
        }
    }
}