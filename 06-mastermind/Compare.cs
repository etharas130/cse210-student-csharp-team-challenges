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
            Console.WriteLine($"{_number}");
            return _number;
        }

        public int GetNumber()
        {
            return _number;
        }
        public bool IsCorrect(int guess)
        {
            bool correctNumber = false;
            if (guess == _number)
            {
                correctNumber = true;
            }
            return correctNumber;
        }
        
        // compares the player's guess to the random number 
        // and returns a complicated hint :) 
        public string CompareGuess(int guess)
        {
            string hint = "";
            string number = _number.ToString();
            string guessS = guess.ToString();
            if ( guess == 0)
            {
                hint = "****";
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (guessS[i] == number[i])
                    {
                        hint += "X";
                    }
                    else
                    {
                        bool match = false;
                        for (int x = 0; x < 4; x++)
                        {

                            if (guessS[i] == number[x])
                            {
                                match = true;
                            }
                        }
                        if (match == true)
                        {
                            hint += "O";
                        }
                        else
                        {
                            hint += "*";
                        }
                    }
                }
            }
            return hint;
        }
    }
}