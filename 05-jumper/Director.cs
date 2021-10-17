using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Director
    {
        bool _keepPlaying = true;
        Jumper _jumper = new Jumper();
        UserServices _userServices = new UserServices();
        SecretKeeper _secretKeeper = new SecretKeeper();
        string _letter;
        bool _correct;
        int _wrongGuesses = 0;

        // is the main function in director, runs the game.
        public void StartGame()
        {
            SetUpGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        // does the starting set up for the game, only get's called once.
        public void SetUpGame()
        {
            _secretKeeper.SelectSecretWord();
            _secretKeeper.GetUnderscores();
            _secretKeeper.DisplayUnderscores();
            _jumper.GetChute();
        }
        
        // gets the users guess
        public void GetInputs()
        {
            _letter = _userServices.GetLetterFromUser();
        }
        // update display and determines whether the game is over or not.
        public void DoUpdates()
        {
            _correct = _secretKeeper.CheckGuess(_letter);
            if (_correct == true)
            {
                _secretKeeper.ReplaceUnderscores(_letter);
            }
            else
            {
                _wrongGuesses = _jumper.CutLine();
            }
            int numUnderscores = _secretKeeper.NumUnderscores();
            if (numUnderscores == 0 || _wrongGuesses >= 3)
            {
                _keepPlaying = false;
            }
        }
        // displays the new "board" and word status.
        public void DoOutputs()
        {
            _secretKeeper.DisplayUnderscores();
            _jumper.GetChute();
        }
    }
}