using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        private Roster _roster = null; 
        List<string> _info = new List<string>();
        public Board(Roster roster)
        {
            _roster = roster;
        }

        // --------------------
        // Player Matt: 1111, xooo
        // Player John: ----, ****
        // --------------------
        // John's turn:
        // What is your guess? 4356
        // 

        public override string ToString()
        {
            string text = "\n--------------------\n";
            
            text += _roster.PrintAllPlayers();

            text += "--------------------\n";

            return text;
        }
        
    }
}