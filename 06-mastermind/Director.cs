using System;

namespace _06_mastermind
{
    public class Director
    {
        private UserServices _userService = null;
        private Roster _roster = null;
        private Board _board = null;
        private Compare _compare = null;
        private bool _keepPlaying = true;

        public Director()
        {
            _userService = new UserServices();
            _roster = new Roster();
            _compare = new Compare();
            _board = new Board(_roster);
        }
        public void StartGame()
        {
            InitScreen();
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                // DoUpdates();
                DoOutputs();
            }
        }

        public void InitScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
        }

        private void PrepareGame()
        {
            _compare.GenerateNumber();
            for (int i = 0; i < 2; i++)
            {
                string prompt = $"Enter a name for player {i + 1}: ";
                string name = _userService.GetStringInput(prompt);

                Player player = new Player(name, _compare);
                _roster.AddPlayer(player);
            }
            _roster.JustifyPlayerNames();
        }

        private void GetInputs()
        {
            string board = _board.ToString();
            _userService.DisplayText(board);

            Player currentPlayer = _roster.GetCurrentPlayer();
            _userService.DisplayText($"{currentPlayer.GetName().Trim()}'s turn:");

            int guessNum = _userService.GetNumberInput("What is your guess? ");
            while (guessNum < 1000 || guessNum > 9999)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1); // back up and overwrite the same line
                guessNum = _userService.GetNumberInput("What is your guess?       \b\b\b\b\b\b"); // print the prompt over again
            }
            currentPlayer.GetGuess().SetGuessValue(guessNum);
        }

        // private void DoUpdates()
        // {
        //     Player currentPlayer = _roster.GetCurrentPlayer();
        // }

        private void DoOutputs()
        {
            if (_roster.GetCurrentPlayer().GuessIsCorrect())
            {
                Player winningPlayer = _roster.GetCurrentPlayer();
                string name = winningPlayer.GetName();

                _userService.DisplayText($"{name} won!");
                _keepPlaying = KeepPlaying();
                if (_keepPlaying)
                {
                    _compare.GenerateNumber();
                    _roster.ResetPlayers();
                }
            }

            _roster.AdvanceNextPlayer();
        }

        private bool KeepPlaying()
        {            
            string response = _userService.GetStringInput("Do you want to play again (yes/no)? ");
            while (response != "yes" && response != "no")
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                response = _userService.GetStringInput("Do you want to play again (yes/no)?       \b\b\b\b\b\b");
            }
            if (response == "yes")
            {
                return true;
            }
            // if they didn't say "yes"
            return false; 
        }
    }
}