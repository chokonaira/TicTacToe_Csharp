    using System;

    namespace TicTacToe
    {
        public class Message
        {
            public string WelcomeMassage { get; }
            public string GameInstruction { get; }
            public string GameMode { get; }
            public string WinMessage { get; set; }
            public string TurnMessage { get; set; }
            public string StartAgain { get; set; }


            public Message()
            {
                WelcomeMassage = "Welcome to Tic Tac Toe!";
                GameInstruction = "These are the different move positions you can make";
                GameMode = "Choose your prefered mode and press enter.\n1: Human Vs. Human\n2: Human Vs. Computer";
                StartAgain = "Tap [Y] and enter to play again or Tap any key to quit";
            }
            public string SetWinMessage(char winner)
            {
                return WinMessage = $"Congratulations player { winner } has won!";
            }
            public string ToggleMessage(char symbol)
            {
                return TurnMessage = $"Its player { symbol } turn";
            }
        }
    }
    

