using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Jumper
    {
        string _guess;
        List<string> _underscores = new List<string>(); 

        public void DisplayUnderscore(string word)
        {
            foreach (char letter in word)
            {
                _underscores.Add("_ ");
            }

            Console.WriteLine(_underscores);
        }

        public string GuessLetter()
        {
            Console.WriteLine();
            Console.Write("Guess a letter [a-z]: ");
            string _guess = Console.ReadLine();

            return _guess;
        }

        public bool IsGuessRight(string _guess, List<string> underscoreList)
        {
            if (_guess in _underscoreList)
            {
                return true;
            }

            else
            {
                return false; 
            }
        }

    }
}