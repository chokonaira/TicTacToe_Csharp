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
                    Colors(ConsoleColor.Red, validate.Message);
                    output.DisplayArray(board.GameBoard);
                    continue;
                }

                board.MakeMove(player.Symbol, int.Parse(input));

                output.DisplayArray(board.GameBoard);

                if (board.IsGameOver())
                {
                    break;
                }

                player.TogglePlayer();
                Colors(ConsoleColor.Yellow, message.ToggleMessage(player.Symbol));
            }
                //check win
                if (board.CheckWin())
                {
                    Colors(ConsoleColor.Green, message.SetWinMessage(player.Symbol));
                }
                //check draw
                if (board.CheckDraw())
                {
                    Colors(ConsoleColor.Yellow, board.DrawMessage);
                }
                Colors(ConsoleColor.Blue, message.StartAgain);
        }

        static void Colors(ConsoleColor color, string message)
        {
            IConsole console = new ConsoleWrapper();
            Output output = new Output(console);

            Console.ForegroundColor = color;
            output.DisplayString(message);
            Console.ResetColor();
        }
    }
}
