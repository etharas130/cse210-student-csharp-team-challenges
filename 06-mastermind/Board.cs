using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        public Board()
        {
            Prepare();
        }

        private void Prepare()
        {

        }

        public void Apply(Guess guess)
        {
            int guess = guess.GetGuess();

        }

        public bool IsCorrect()
        {
            bool correctNumber = false;

            return correctNumber;
        }

        public override string ToString()
        {
            string text = "\n--------------------\n";

            text += "--------------------\n";

            return text;
        }
        
    }
}