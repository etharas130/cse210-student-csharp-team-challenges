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
        public Player(string name, Compare compare)
        {
            _name = name;
            _guess = new Guess(compare);
        }

        public string GetName()
        {
            return _name;
        }

        public void PadName()
        {
            _name += " ";
        }

        public string PrintPlayer()
        {
            string text;

            text = $"Player {_name}: ";

            if (_guess.GetGuessValue() == 0)
            {
                text += $"----, ";
            }
            else
            {
                text += $"{_guess.GetGuessValue()}, ";
            }
            text += $"{_guess.PrintGuessResult()}\n";

            return text;
        }

        public Guess GetGuess()
        {
            return _guess;
        }

        public bool GuessIsCorrect()
        {
            return _guess.TestGuess();
        }
    }
}
