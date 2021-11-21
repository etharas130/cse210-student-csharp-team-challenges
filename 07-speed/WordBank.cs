using System;
using System.Collections.Generic;
using Raylib_cs;
using System.IO;

namespace _07_speed
{
    public class WordBank
    {
        Random randomGenerator = new Random();
        string[] _dictionary;

        public WordBank()
        {
            _dictionary = System.IO.File.ReadAllLines(@"dictionary.txt");
        }

        public string GenerateWord()
        {
            string word = _dictionary[randomGenerator.Next(0, _dictionary.Length)];

            return word;
        }
    }
}
