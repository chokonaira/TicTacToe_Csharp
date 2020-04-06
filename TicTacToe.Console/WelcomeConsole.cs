using System;

namespace TicTacToe.ConsoleGame
{
    public class WelcomeConsole
    {
        public static void Main(string[] args)
        {
            Welcome game = new Welcome();
            string message = game.WelcomeMassage();
            Console.WriteLine(message);
        }
    }
}
