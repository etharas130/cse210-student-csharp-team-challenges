using System;

namespace _06_mastermind
{

    class Guess
    {
        private int _guess;

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