using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        private Compare _compare = new Compare();

        List<string> _info = new List<string>();
        bool _turn = true;
        public Board()
        {
            Prepare();
        }

        // --------------------
        // Player Matt: 1111, xooo
        // Player John: ----, ****
        // --------------------
        // John's turn:
        // What is your guess? 4356
        // 
        private void Prepare()
        {
            string text = "";
            
        }

        public void Apply(Guess guess)
        {
            int thisGuess = guess.GetGuess();

        }

        public bool IsCorrect()
        {
            bool correctNumber = false;

            return correctNumber;
        }

        public override string ToString()
        {
            string text = "\n--------------------\n";
            text += $"Player {player1}: {guess1}, {_compare.CompareGuess(guess, rNumber)}"
            text += $"Player {player2}: {guess2}, {_compare.CompareGuess(guess, rNumber)}"
            text += "--------------------";

            return text;
        }
        
    }
}