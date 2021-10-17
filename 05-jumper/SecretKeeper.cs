using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class SecretKeeper
    {
        List<char> _secretWordLetters = new List<char>();
        List<char> _underscores = new List<char>();
        List<char> _guessedLetters = new List<char>();
        int _length;

        // chooses the secret word
        public void SelectSecretWord()
        {
            Random randomGenerator = new Random();
            List<string> words = new List<string>();

            words.Add("forward");
            words.Add("backward");
            // This is how you'll know which is the secret word.

            words.Add("entropy");
            words.Add("order");
            words.Add("galaxy");
            words.Add("energy");
            words.Add("cargo");
            words.Add("airplane");
            words.Add("hairpin");

            string secretWord = words[randomGenerator.Next(1, words.Count)];

            foreach (char letter in secretWord)
            {
                _secretWordLetters.Add(letter);
            }
            _length = _secretWordLetters.Count;
        }

        // checks whether the user's guess is equivalent to one or more of
        // the letters in the secret word
        public bool CheckGuess(string guess)
        {
            foreach (char letter in guess)
            {
                foreach (char character in _secretWordLetters)
                {
                    if (letter == character)
                    {
                        // adds the guessed letter to a list to be used in the underscore funtion.
                        _guessedLetters.Add(letter);
                        // As soon as it finds a matching letter, it returns true and leaves the function.
                        return true;
                    } 
                }
            }
            // if it goes through the entire list of letters and none match, returns false.
            return false;
        }

        // Creates the basic list for the underscores to be used throughout program.
        public void GetUnderscores()
        {
            foreach (char letter in _secretWordLetters)
            {
                _underscores.Add('_');
            }
        }
        
        // if the user's guess is correct, this function replaces
        // the correct underscores with the guess's letter.
        public void ReplaceUnderscores(string letter)
        {
            for (int i = 0; i < _length; i++)
            {
                foreach (char character in _guessedLetters)
                {
                    if (character == _secretWordLetters[i])
                    {
                        _underscores[i] = character;
                    }
                }
            }
        }

        // Displays the underscored word with the guessed letters.
        public void DisplayUnderscores()
        {
            Console.WriteLine("");
            for (int i = 0; i < _length; i++)
            {
                Console.Write($"{_underscores[i]} ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        // determines how many letter's Have NOT been guessed and 
        // returns that number to Director.
        public int NumUnderscores()
        {
            int numUnderscores = 0;
            for (int i = 0; i < _length; i++)
            {
                if (_underscores[i] == '_')
                {
                    numUnderscores++;
                }
            }
            return numUnderscores;
        }
    }
}
