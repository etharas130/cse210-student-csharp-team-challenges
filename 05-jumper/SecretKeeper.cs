using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class SecretKeeper
    {
        List<string> _secretWordLetters = new List<string>();
        List<string> _underscores = new List<string>();
        List<string> _guessedLetters = new List<string>();
        
        // chooses the secret word
        public void SelectSecretWord()
        {
            Random randomGenerator = new Random();
            List<string> words = new List<string>();

            words.Add("forward"); //"r" count: 2
            words.Add("backward"); //"r" count: 1
            // Always guess "r"
            // This is how you'll know which is the secret word.

            // words.Add("entropy");
            // words.Add("order");
            // words.Add("galaxy");
            // words.Add("energy");
            // words.Add("cargo");
            // words.Add("airplane");
            // words.Add("hairpin");

            string secretWord = words[randomGenerator.Next(1, words.Count)];

            _secretWordLetters.Add(secretWord);
        }

        // checks whether the user's guess is equivalent to one or more of
        // the letters in the secret word
        public bool CheckGuess(string guess)
        {
            foreach (char letter in guess)
            {
                foreach (string letter2 in _secretWordLetters)
                {
                    char character = char.Parse(letter2);
                    if (letter == character)
                    {
                        // adds the guessed letter to a list to be used in the underscore funtion.
                        _guessedLetters.Add(letter2);
                        // As soon as it finds a matching letter, it returns true and leaves the function.
                        return true;
                    } 
                }
            }
            // if it goes through the entire list of letters and none match, returns false.
            return false;
        }

        // displays to the user the underscores of the secret word 
        // and whatever correct letters have been chosen
        public List<string> GetUnderscores()
        {
            foreach (string letter in _secretWordLetters)
            {
                _underscores.Add("_ ");
            }
            return _underscores;
        }
        
        // if the user's guess is correct, this function replaces
        // the correct underscores with the guess's letter
        public void ReplaceUnderscores(string letter)
        {
            int length = _secretWordLetters.Count;
            for (int i = 0; i < length; i++)
            {
                foreach (string character in _guessedLetters)
                {
                    if (character == _secretWordLetters[i])
                    {
                        _underscores[i] = character;
                    }
                }
            }
        }
    }
}
