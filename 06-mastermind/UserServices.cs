using System;

namespace _06_mastermind
{
    public class UserServices
    {
        
        /// Displays the provided text.
        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        /// Gets a numeric value from the user after displaying the provided
        public int GetNumberInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            // One of the benefits of abstracting this user i/o into this service class
            // is that we could add extra functionality here, such as checking
            // for a valid number and re-prompting if the user entered something invalid.
            
            // For simplicity, right now, it assumes proper input.
            int numericChoice = int.Parse(userInput);
            return numericChoice;
        }

        /// Gets a string value from the user after displaying the provided prompt text.
        public string GetStringInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}