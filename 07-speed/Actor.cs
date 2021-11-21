using System;

namespace _07_speed
{
    /// <summary>
    /// Base class for all actors in the game.
    /// </summary>
    public class Actor
    {
        protected Point _position;
        protected Point _velocity;

        protected Point _fractionalMovement;

        protected int _width = Constants.DEFAULT_SQUARE_SIZE;
        protected int _height = Constants.DEFAULT_SQUARE_SIZE;

        protected string _text = "";

        public Actor()
        {

        }

        public bool HasText()
        {
            return _text != "";
        }

        public bool HasBox()
        {
            return _width > 0 && _height > 0;
        }

        public string GetText()
        {
            return _text;
        }

        public int GetX()
        {
            return _position.GetX();
        }

        public int GetY()
        {
            return _position.GetY();
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public Point GetVelocity()
        {
            return _velocity;
        }

        public void SetVelocity(Point newVelocity)
        {
            _velocity = newVelocity;
        }

        /// <summary>
        /// Moves the actor forward one space according to the current
        /// velocity.
        /// </summary>
        public void MoveNext()
        {
            int x;
            int y;
            // slowing the velocity by a fraction of a letter
            _fractionalMovement = _fractionalMovement.Add(_velocity);
            
            if (_fractionalMovement.GetX() > Constants.LETTER_FRACTION)
            {
                x = _position.GetX();
                x -= _fractionalMovement.GetX() / Constants.LETTER_FRACTION;
                if (x < 0)
                {
                    x = Constants.MAX_X;
                }
                y = _position.GetY();
                _position = new Point(x, y);
                x = _fractionalMovement.GetX();
                x %= Constants.LETTER_FRACTION;
                y = _fractionalMovement.GetY();
                _fractionalMovement = new Point(x, y);
            }

            if (_fractionalMovement.GetY() > Constants.LETTER_FRACTION)
            {
                y = _position.GetY();
                y -= _fractionalMovement.GetY() / Constants.LETTER_FRACTION;
                if (y < 0)
                {
                    y = Constants.MAX_Y;
                }
                x = _position.GetX();
                _position = new Point(x, y);
                y = _fractionalMovement.GetY();
                y %= Constants.LETTER_FRACTION;
                x = _fractionalMovement.GetX();
                _fractionalMovement = new Point(x, y);
            }

        }

        public override string ToString()
        {
            return $"Position: ({_position.GetX()}, {_position.GetY()}), Velocity({_velocity.GetX()}, {_velocity.GetY()})";
        }

    }

}