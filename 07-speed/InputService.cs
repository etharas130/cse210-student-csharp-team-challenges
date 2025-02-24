using System;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        public InputService()
        {

        }

        // public bool IsLeftPressed()
        // {
        //     return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT);
        // }

        // public bool IsRightPressed()
        // {
        //     return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT);
        // }
        // public bool IsUpPressed()
        // {
        //     return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP);
        // }
        // public bool IsDownPressed()
        // {
        //     return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN);
        // }

        public string GetLetter()
        {
            int keyInt = Raylib.GetKeyPressed();

            string keyString = "";

            if (keyInt != 0)
            {
                if ((Raylib_cs.KeyboardKey) keyInt == Raylib_cs.KeyboardKey.KEY_ENTER)
                {
                    keyString = "\n";
                }
                else
                {
                    char keyChar = (char)keyInt;
                    if (!Char.IsLetter(keyChar))
                    {
                        return keyString;
                    }
                    keyString = keyChar.ToString().ToLower();
                }
            }
            return keyString;

        }
        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}