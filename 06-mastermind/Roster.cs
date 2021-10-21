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

        /// Advances the current player to be the next one in the roster.
        public void AdvanceNextPlayer()
        {
            _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Count;
        }
    }
}