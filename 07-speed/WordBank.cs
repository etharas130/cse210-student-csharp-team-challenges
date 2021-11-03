using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    public class WordBank
    {

        private List<string> _words = new List<string>();
        Random randomGenerator = new Random();

        public WordBank()
        {
            AddToWord();
        }
        public void AddToWord()
        {
            _words.Add("Brenin");
            _words.Add("amalgamation");
            _words.Add("Linda");
            _words.Add("Collette");
            _words.Add("blurb");
            _words.Add("supercalifragilisticexpialidocious");
            _words.Add("hyperactive");
            _words.Add("dolphin");
            _words.Add("Schizophrenia");
            _words.Add("Psychology");
            _words.Add("Star Wars");
            _words.Add("Lightsaber");
            _words.Add("exhange");
            _words.Add("supernova");
            _words.Add("titanium");
            _words.Add("kangaroo");

        }

        public string GenerateWord()
        {
            string word = _words[randomGenerator.Next(0, _words.Count - 1)];

            //_text = word;
            return word;
        }

        public List<string> GetWords()
        {
            return _words; 
        }

    }
}
