using System;

namespace TicTacToe.ConsoleGame
{
    public class GameConsole
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Message message = new Message();

                Board board = new Board(3);

                Validation validate = new Validation();

                IConsole console = new ConsoleWrapper();
                Output output = new Output(console);

                Colors(ConsoleColor.Green, message.WelcomeMassage);

                Colors(ConsoleColor.Green, message.GameMode);

                string mode = Console.ReadLine();

                if (!validate.CheckGameMode(mode))
                {
                    Colors(ConsoleColor.Red, validate.Message);
                    continue;
                }

                Player player = new Player('X');

                output.DisplayArray(board.GameBoard);

                Colors(ConsoleColor.Green, message.GameInstruction);

                Colors(ConsoleColor.Yellow, $"Its Player {player.Symbol}'s Turn.");

                GameLoop gameLoop = new GameLoop();
                gameLoop.Loop(board, validate, player, output, message);

                if (board.WinningPlayer() == player.Symbol)
                {
                    Colors(ConsoleColor.Green, message.SetWinMessage(player.Symbol));
                }
                if (board.CheckDraw())
                {
                    Colors(ConsoleColor.Yellow, board.DrawMessage);
                }
                    Colors(ConsoleColor.Blue, message.StartAgain);

                string answer = Console.ReadLine();

                if (board.PlayAgain(answer))
                {
                    continue;
                }
                return;
            }
        }
        public static void Colors(ConsoleColor color, string message)
        {
            IConsole console = new ConsoleWrapper();
            Output output = new Output(console);

            Console.ForegroundColor = color;
            output.DisplayString(message);
            Console.ResetColor();
        }
    }
}
