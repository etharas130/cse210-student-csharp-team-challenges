using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Jumper
    {
        List<char> _underscores = new List<char>(); 
        SecretKeeper _secretKeeper = new SecretKeeper();
        int _wrongGuesses = 0;
        char[,] _chute = new char[7 , 7] {
                {' ', ' ', '_', '_', '_', ' ', ' '},{' ','/', '_', '_', '_', '\\',' '},{' ', '\\', ' ', ' ', ' ', '/', ' '},
                {' ', ' ', '\\', ' ', '/', ' ', ' '},{' ', ' ', ' ', '0', ' ', ' ', ' '},{' ', ' ', '/', '|', '\\', ' ', ' '},
                {' ', ' ', '/', ' ', '\\', ' ', ' '}};

        // Adds 1 to the variable keeping track of wrong guesses,
        // and returns it to director.
        public int CutLine()
        {
            return _wrongGuesses++;
        }
        
        // displays the current visual status of the parachute and jumper.
        public void GetChute()
        {
            for (int row = _wrongGuesses; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write($"{_chute[row , col]}");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^^^^^^^");
            Console.WriteLine("");
        }
    }
}