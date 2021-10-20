using System;

namespace _06_mastermind
{
    public class UserServices
    {
        public void DisplayText()
        {
            
        }
        public string GetStringInput(string promptText)
            {
                Console.Write(promptText);
                string userInput = Console.ReadLine();
                
                return userInput;
            }
    }
}