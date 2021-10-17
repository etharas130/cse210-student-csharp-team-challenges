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

        // if the the user's guess is incorrect, the jumper must cut a parachute line
        public void CutLine()
        {
            
        }
        
        // displays the current visual status of the parachute jumper
        public string GetChute()
        {
            char[,] board = new char[7 , 7] {
                {' ', ' ', '_', '_', '_', ' ', ' '},{' ','/', '_', '_', '_', '\\',' '},{' ', '\\', ' ', ' ', ' ', '/', ' '},
                {' ', ' ', '\\', ' ', '/', ' ', ' '},{' ', ' ', ' ', '0', ' ', ' ', ' '},{' ', ' ', '/', '|', '\\', ' ', ' '},
                {' ', ' ', '/', ' ', '\\', ' ', ' '}};
                for (int row = 0; row < 7; row++)
                {
                    for (int col = 0; col < 7; col++)
                    {
                        Console.Write($"{board[row , col]}");
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