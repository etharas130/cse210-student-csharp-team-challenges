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

        string newWord;

        public Word()
        {
            PrepareWord();
        }

        private void PrepareWord()
        {
            _text = _wordBank.GenerateWord();

            int x = Constants.MAX_X - 20;
            int y = randomGenerator.Next(10, Constants.MAX_Y - 25);

            int dx = randomGenerator.Next(1,4);
            int dy = 0;

            _position = new Point(x,y);
            _width = 0;
            _height = 0;

            _velocity = new Point(-dx,dy);
            
        }

        public void IsOffScreen()
        {
            
        }
        
        // public void GenerateWord()
        // {
        //     string word = _words[randomGenerator.Next(0, _words.Count - 1)];

        //     _text = word;
        // }

        // private void AddToWord()
        // {
        //     _words.Add("Brenin");
        //     _words.Add("amalgamation");
        //     _words.Add("Linda");
        //     _words.Add("Collette");
        //     _words.Add("blurb");
        //     _words.Add("supercalifragilisticexpialidocious");
        //     _words.Add("hyperactive");
        //     _words.Add("dolphin");
        //     _words.Add("Schizophrenia");
        //     _words.Add("Psychology");
        //     _words.Add("Star Wars");
        //     _words.Add("Lightsaber");
        //     _words.Add("exhange");
        //     _words.Add("supernova");
        //     _words.Add("titanium");
        //     _words.Add("kangaroo");
        // }


    }
}