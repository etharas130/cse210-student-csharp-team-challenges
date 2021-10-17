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

        // if the the user's guess is incorrect, the jumper must cut a parachute line
        public int CutLine()
        {
            // variable that keeps track of how many wrong answers there have been so as
            // to determine how many rows get printed
            // double for loop and a variable to change which row in the array it starts on
            return _wrongGuesses++;
        }
        
        // displays the current visual status of the parachute jumper
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