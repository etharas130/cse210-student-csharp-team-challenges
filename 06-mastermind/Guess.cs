using System;

namespace _06_mastermind
{

    /// contains the current guess 
    class Guess
    {
        private int _guess;
        /// Initializes the guess with the provided number
        public Guess(int guess)
        {
            _guess = guess;
        }

        public int GetGuess()
        {
            return _guess;
        }
    }
}