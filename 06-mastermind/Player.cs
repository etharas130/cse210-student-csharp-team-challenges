using System;

namespace _06_mastermind
{
    
    /// Represents a person taking part in the game. This course keeps track
    /// of their name and their current move.
    class Player
    {
        private string _name;
        private Guess _guess;

        /// Initializes a new player with the provided name.
        public Player(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetGuess(Guess guess)
        {
            _guess = guess;
        }

        public Guess GetGuess()
        {
            return _guess;
        }
    }
}
