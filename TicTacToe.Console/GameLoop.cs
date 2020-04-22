using System;
namespace TicTacToe.ConsoleGame
{
    public class GameLoop
    {
        public void Loop(Board board, Validation validate, Player player, Output output, Message message)
        {
            while (!board.IsGameOver())
            {
                string input = Console.ReadLine();

                if (!validate.IsValid(board, input))
                {
                    GameConsole.Colors(ConsoleColor.Red, validate.Message);
                    output.DisplayArray(board.GameBoard);
                    continue;
                }

                board.MakeMove(player.Symbol, int.Parse(input));

                output.DisplayArray(board.GameBoard);
                Minimax minimax = new Minimax('X', 'O');

                Console.WriteLine("----------------------1");
                Console.WriteLine(minimax.Evaluate(board));
                Console.WriteLine("----------------------2");

                if (board.IsGameOver())
                {
                    break;
                }

                player.TogglePlayer();
                GameConsole.Colors(ConsoleColor.Yellow, message.ToggleMessage(player.Symbol));
            }
                
        }
    }
}
