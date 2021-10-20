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
            _compare.GenerateNumber();
            string prompt = $"Enter a name for player {i + 1}: ";
            string name = _userService.GetStringInput(prompt);

            Player player = new Player(name);
            _roster.AddPlayer(player);
        }

        private void GetInputs()
        {

        }

        private void DoUpdates()
        {

        }

        private void DoOutputs()
        {

        }
    }
}