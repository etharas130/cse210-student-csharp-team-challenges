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
        // update display
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
        // displays the new "board" and word status. Determines if game is over or not
        public void DoOutputs()
        {
            _secretKeeper.DisplayUnderscores();
            _jumper.GetChute();
        }
    }
}