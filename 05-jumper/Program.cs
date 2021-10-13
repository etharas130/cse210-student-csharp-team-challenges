using System;
using System.Collections.Generic;

namespace _05_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "word";
            int countDown = word.Length;
            List<string> displayWord = new List<string>();

            for (int i = 0; i < word.Length; i++)
            {
                displayWord.Add("_ ");
                Console.Write(displayWord[i]);
            }
            Console.WriteLine("");
            Console.Write("Guess a letter [a-z]: ");
            string guess = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                
            }

            
        }
    }
}
