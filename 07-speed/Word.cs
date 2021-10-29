using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Word : Actor
    {
        List<string> _words = new List<string>();

        private void AddToWord()
        {
            _words.Add("Brenin");
            _words.Add("amalgamation");
            _words.Add("Linda");
            _words.Add("Collette");
            _words.Add("blurb");
            _words.Add("supercalifragilisticexpialidocious");
        }

        
    }
}