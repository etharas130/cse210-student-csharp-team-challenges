using System;

namespace _06_mastermind
{
    /// contains the current guess 
    class Guess
    {
        int _guess = 0;
        Compare _compare; 
        /// Saves the guess in the players corresponding spot

        public Guess(Compare compare)
        {
            _compare = compare; 
        }
        public void SetGuessValue(int guessNum)
        {
            _guess = guessNum;
        }

        public int GetGuessValue()
        {
            return _guess;
        }

        public string PrintGuessResult()
        {
            return _compare.CompareGuess(_guess);
        }

        public bool TestGuess()
        {
            return _compare.IsCorrect(_guess);
        }
    }
}