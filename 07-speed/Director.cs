using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();
        ScoreBoard _scoreBoard = new ScoreBoard();
        Buffer _buffer = new Buffer();
        private List<Word> _words = new List<Word>(); 
        WordBank _wordBank = new WordBank();
        Random _randomGenerator = new Random();
        

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

                if (_inputService.IsWindowClosing())
                {
                    _keepPlaying = false;
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Speed Game", Constants.FRAME_RATE);
            for (int numWords = 0; numWords < Constants.WORDS_ON_SCREEN; numWords++)
            {
                Word w = new Word();
                _words.Add(w);
            }   
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        private void GetInputs()
        {
            string letter = _inputService.GetLetter();

            if (!(letter is ""))
            {
                if (letter == "\n")
                {
                    _buffer.ClearLetter();
                }
                else
                {
                    _buffer.AddLetter(letter);
                }
            }
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            foreach (Word word in _words)
            {
                word.MoveNext();
            }
            CheckBufferForMatch();
            _buffer.UpdateText();
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        {
            _outputService.StartDrawing();

            _outputService.DrawActor(_scoreBoard);
            _outputService.DrawActor(_buffer);

            foreach (Word word in _words)
            {
                _outputService.DrawActor(word);
            }

            _outputService.EndDrawing();
        }

        public void CheckBufferForMatch()
        {
            bool changed = false;
            foreach (Word word in _words)
            {
                if (_buffer.Match(word))
                {
                    _words.Remove(word);
                    _buffer.ClearLetter();
                    _scoreBoard.AddPoints(word.GetText().Length);
                    changed = true;
                    break;
                }
            }
            if (changed)
            {
                int num = _randomGenerator.Next(0, 10);
                if (_words.Count < Constants.WORDS_ON_SCREEN)
                {
                    Word w = new Word();
                    _words.Add(w);
                } 
                if (num > 2 && _words.Count < 3 * Constants.WORDS_ON_SCREEN)
                {
                    Word w = new Word();
                    _words.Add(w);
                }   
                if (num > 5 && _words.Count < 3 * Constants.WORDS_ON_SCREEN)
                {
                    Word w = new Word();
                    _words.Add(w);
                }                 
            }
        }


        


    }
}
