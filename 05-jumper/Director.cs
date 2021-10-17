using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Director
    {
        bool _keepPlaying = true;
        //string _word = "";
        //string _guess;

        //bool _verdict;
        Jumper _jumper = new Jumper();
        //WordBank _wordBank = new WordBank();
        UserServices _userServices = new UserServices();
        //Board _board = new Board();

        SecretKeeper _secretKeeper = new SecretKeeper();
        string _letter;
        bool _correct;
        string _chute;

        public void StartGame()
        {
            //SetUpGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

            }
        }
        // creates the word and pulls back to director. sends the word to board ot creat board, and then sends board and word to user to be displayed
        // public void SetUpGame()
        // {
        //     _word = _wordBank.WordGenerator();
        //     _jumper.DisplayUnderscore(_word);
        //     _board.GenerateBoard();
        // }
        
        
        // gets the users guess
        public void GetInputs()
        {
            //_guess = _jumper.GuessLetter();
            _letter = _userServices.GetLetterFromUser();
        }
        // update display
        public void DoUpdates()
        {
            //_verdict = _jumper.IsGuessRight(_guess, _underscores); 
            _correct = _secretKeeper.CheckGuess(_letter);
            if (_correct == true)
            {
                _secretKeeper.ReplaceUnderscores(_letter);
            }
            else
            {
                _jumper.CutLine();
            }
        }
        // displays the new "board" and word status. Determines if game is over or not
        public void DoOutputs()
        {
            _jumper.GetChute();
            _secretKeeper.GetUnderscores();
            _secretKeeper.DisplayUnderscores();
            Console.WriteLine(_chute);
        }
    }
}