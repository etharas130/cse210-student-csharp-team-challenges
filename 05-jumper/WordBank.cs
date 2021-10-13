using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class WordBank
    {
        public string _wordBank()
        {
            Random randomGenerator = new Random();
            List<string> _words = new List<string>();

            _words.Add("forward");
            _words.Add("backword");
            _words.Add("entropy");
            _words.Add("order");
            _words.Add("galaxy");
            _words.Add("energy");

            string word = _words[randomGenerator.Next(1, _words.Count)];

            return word;

        }

    }
}