using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_jumper
{
    class UserServices
    {
        
        /// <summary>
        /// Gets a letter guess from the user
        /// </summary>
        /// <param> no parameters </param>
        public string GetLetterFromUser()
        {
            Console.WriteLine();
            Console.Write("Guess a letter [a-z]: ");
            string _letter = Console.ReadLine();

            return _letter;
        }
    }
}