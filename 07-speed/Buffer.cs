using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Buffer : Actor
    {
        List<string> _letters = new List<string>();
        public Buffer()
        {
            _position = new Point(1, 375);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }

        private void UpdateText()
        {
            _text = "Buffer: "; //feiowfjw
        }

        public void AddLetter(string letter)
        {
            // It is possible that we could create another Point next to the "Buffer: " text
            // that we type into, rather than adding the letters to the "Buffer: " text itself
            
        }
        public void ClearLetter()
        {

        }
    }
}