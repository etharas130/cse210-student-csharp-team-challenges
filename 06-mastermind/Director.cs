using System;

namespace _06_mastermind
{
    public class Director
    {
        private Board _board = new Board();
        private UserServices _userService = new UserServices();
        private Roster _roster = new Roster();
        private Compare _compare = new Compare();
        private bool _keepPlaying = true;
        public void StartGame()
        {
            PrepareGame();
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        private void PrepareGame()
        {
            for (int i =0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetStringInput(prompt);

                Player player = new Player(name);
                _roster.AddPlayer(player);
            }
        }

        private void GetInputs()
        {
            string board = _board.ToString();
            _userService.DisplayText(board);

            Player currentPlayer = _roster.GetCurrentPlayer();
            _userService.DisplayText($"{currentPlayer.GetName()}'s turn:");

            int guess = _userService.GetNumberInput("What is your guess? ");

            Guess guessP = new Guess(guess);
            currentPlayer.SetGuess(guessP);
        }

        private void DoUpdates()
        {
            Player currentPlayer = _roster.GetCurrentPlayer();
            Guess currentguess = currentPlayer.GetGuess();

            _board.Apply(currentguess);

        }

        private void DoOutputs()
        {
            if (_board.IsCorrect())
            {
                Player winningPlayer = _roster.GetCurrentPlayer();
                string name = winningPlayer.GetName();

                _userService.DisplayText($"{name} won!");
                _keepPlaying = false;
            }

            _roster.AdvanceNextPlayer();

        }
    }
}