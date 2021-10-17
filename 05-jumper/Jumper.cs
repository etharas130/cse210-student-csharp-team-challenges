using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Jumper
    {
        //string _guess;
        string _chute;
        List<string> _underscores = new List<string>(); 
        SecretKeeper _secretKeeper = new SecretKeeper();
        int _wrongGuesses = 0;

        char[,] _board;

        // if the the user's guess is incorrect, the jumper must cut a parachute line
        public void CutLine()
        {
            // variable that keeps track of how many wrong answers there have been so as
            // to determine how many rows get printed
            // double for loop and a variable to change which row in the array it starts on
            for (int col = _wrongGuesses; col < 7; col++)
            {
                for (int row = 0; row < 7; row++)
                {
                    Console.WriteLine($"{_board[row, col]}");
                    Console.WriteLine();
                }
            }
        }
        
        // displays the current visual status of the parachute jumper
        public void GetChute()
        {
            char[,] _board = new char[7 , 7] {
                {' ', ' ', '_', '_', '_', ' ', ' '},{' ','/', '_', '_', '_', '\\',' '},{' ', '\\', ' ', ' ', ' ', '/', ' '},
                {' ', ' ', '\\', ' ', '/', ' ', ' '},{' ', ' ', ' ', '0', ' ', ' ', ' '},{' ', ' ', '/', '|', '\\', ' ', ' '},
                {' ', ' ', '/', ' ', '\\', ' ', ' '}};
                for (int row = 0; row < 7; row++)
                {
                    for (int col = 0; col < 7; col++)
                    {
                        Console.Write($"{_board[row , col]}");
                    }
                }
                Console.WriteLine("^^^^^^^^^^^^^^^");
                Console.WriteLine();
        }

        // public void DisplayUnderscore(string word)
        // {
        //     foreach (char letter in word)
        //     {
        //         _underscores.Add("_ ");
        //     }

        //     Console.WriteLine(_underscores);
        // }

        // public string GuessLetter()
        // {
        //     Console.WriteLine();
        //     Console.Write("Guess a letter [a-z]: ");
        //     string _guess = Console.ReadLine();

        //     return _guess;
        // }

        // public bool IsGuessRight(string _guess, List<string> underscoreList)
        // {
        //     if (_guess in _underscoreList)
        //     {
        //         return true;
        //     }

        //     else
        //     {
        //         return false; 
        //     }
        // }

    }
}