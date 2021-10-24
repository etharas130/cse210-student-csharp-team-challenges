using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<Player> _players = new List<Player>();


        /// Adds a new player to the game.
        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        /// Returns the player whose turn it is.
        public Player GetCurrentPlayer()
        {
            return _players[_currentPlayerIndex];
        }

        // ternary operator area - simple if test
        public Player GetPlayer(int player)
        {
            return _players[player == 0 ? 0 : 1];
        }

        public string PrintAllPlayers()
        {
            string text = "";

            foreach (Player player in _players)
            {
                text += player.PrintPlayer();
            }

            return text; 
        }

        /// Advances the current player to be the next one in the roster.
        public void AdvanceNextPlayer()
        {
            _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Count;
        }

        public void JustifyPlayerNames()
        {
            // find longest name
            int longest = 0;
            foreach (Player player in _players)
            {
                if (player.GetName().Length > longest)
                {
                    longest = player.GetName().Length;
                }
            }
            // add spaces to shorter names
            foreach (Player player in _players)
            {
                for (int index = player.GetName().Length; index < longest; index++)
                {
                    player.PadName();
                }
            }
        }
        public void ResetPlayers()
        {
            foreach (Player player in _players)
            {
                player.GetGuess().SetGuessValue(0);
            }
        }
    }
}