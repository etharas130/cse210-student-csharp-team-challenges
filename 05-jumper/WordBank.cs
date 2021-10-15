using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class WordBank
    {
        public string WordGenerator()
        {
            Random randomGenerator = new Random();
            List<string> _words = new List<string>();

            _words.Add("forward");
            // _words.Add("backward");
            // _words.Add("entropy");
            // _words.Add("order");
            // _words.Add("galaxy");
            // _words.Add("energy");
            // _words.Add("cargo");
            // _words.Add("airplane");
            // _words.Add("hairpin");

            string word = _words[randomGenerator.Next(1, _words.Count)];

            return word;
        }

    }
}