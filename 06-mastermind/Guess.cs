using System;

namespace _06_mastermind
{
    /// contains the current guess 
    class Guess
    {
        int[] _guess = new int[2];
        int _turn = 0;
        /// Saves the guess in the players corresponding spot
        public void SaveGuess(int guess)
        {
            _guess[_turn] = guess;
            Console.WriteLine($"{_guess[_turn]}");
            if (_turn == 0)
            {
                _turn = 1;
            }
            else if (_turn == 1)
            {
                _turn = 0;
            }
        }

        public int[] GetGuess()
        {
            return _guess;
        }
    }
}