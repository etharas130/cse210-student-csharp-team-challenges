using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Word : Actor
    {   
        // private List<string> _words = new List<string>();
        Random randomGenerator = new Random();
        WordBank _wordBank = new WordBank();

        public Word()
        {
            PrepareWord();
        }

        private void PrepareWord()
        {
            _text = _wordBank.GenerateWord().ToLower();

            int x = Constants.MAX_X - 20;
           
            int y = randomGenerator.Next(20, Constants.MAX_Y - 45); 

            int dx = randomGenerator.Next(Constants.MINIMUM_SPEED, Constants.MAXIMUM_SPEED);
            int dy = 0;

            _position = new Point(x,y);
            _width = 0;
            _height = 0;
            _fractionalMovement = new Point(0,0);
            _velocity = new Point(dx,dy);
            
        }
    }
}