using System;

namespace TicTacToe
{
    public class Message
    {
        public string WelcomeMassage { get; }
        public string GameInstruction { get; }
        public string WinMessage { get; set; }

        public Message()
        {
            WelcomeMassage = "Welcome to Tic Tac Toe!";
            GameInstruction = "These are the diffenrent move positions you can make";
        }
        public string SetWinMessage(char winner)
        {
            return WinMessage = $"Congratulations player { winner } has won!";
        }
    }
    
}
