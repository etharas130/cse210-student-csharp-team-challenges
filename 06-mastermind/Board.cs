using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        private Compare _compare = new Compare();

        private Guess _guess = new Guess();
        List<string> _info = new List<string>();
        int _turn = 0;
        public Board()
        {

        }

        // --------------------
        // Player Matt: 1111, xooo
        // Player John: ----, ****
        // --------------------
        // John's turn:
        // What is your guess? 4356
        // 

        public bool IsCorrect()
        {
            bool correctNumber = false;
            int [] guesses = _guess.GetGuess();
            if (_turn == 0)
            {
                _compare.IsCorrect(guesses[0]);
                _turn = 1;
            }
            else
            {
                _compare.IsCorrect(guesses[1]);
                _turn = 0;
            }

            return correctNumber;
        }

        public override string ToString()
        {
            int [] guesses = _guess.GetGuess();

            string text = "\n--------------------\n";
            
             text += $"Player NAME HERE: ";
            if ( guesses[0] == 0)
            {
                text += $"{guesses[0]}, ";
            }
            else
            {
                text += "----, ";
            }
            text += $"{_compare.CompareGuess(guesses[1])}\n";
            text += $"Player NAME HERE: ";
            if ( guesses[1] == 0)
            {
                text += $"{guesses[1]}, ";
            }
            else
            {
                text += "----, ";
            }
            text += $"{_compare.CompareGuess(guesses[1])}\n";
            text += "--------------------";

            return text;
        }
        
    }
}