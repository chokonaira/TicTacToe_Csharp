using System;
namespace TicTacToe.ConsoleGame
{
    public class WelcomeConsole
    {
        public static void Main(string[] args)
        {
            Welcome game = new Welcome();
            Board board = new Board();
            string message = game.WelcomeMassage;
            string instruction = game.GameInstruction;

            Console.WriteLine(message);
            Console.WriteLine(board.GetBoard());
            Console.WriteLine(instruction);
        }
    }
}
