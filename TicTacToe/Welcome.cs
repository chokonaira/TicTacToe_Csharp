using System;

namespace TicTacToe
{
    public class Welcome
    {
        public string WelcomeMassage { get; }
        public string GameInstruction { get; }

        public Welcome()
        {
            WelcomeMassage = "Welcome to Tic Tac Toe!";
            GameInstruction = "Use symbol X and O, In postion 1 to 9";
        }      
    }
    
}
