using System;
using System.Collections.Generic;
using System.Linq; 

namespace _05_jumper
{
    class UserServices
    {
        string _letter;

        //this funtion prompts the user for their guess in the
        //form of a lowercase letter and returns it to director.
        public string GetLetterFromUser()
        {
            Console.Write("Guess a letter [a-z]: ");
            _letter = Console.ReadLine();

            return _letter;
        }
    }
}