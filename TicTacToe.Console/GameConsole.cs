using System;

namespace TicTacToe.ConsoleGame
{
    public class GameConsole
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                //create message instance
                Message message = new Message();
                //create board instance
                Board board = new Board(3);
                //create validation instance
                Validation validate = new Validation();
                //create first player instance with a symbol
                Player player = new Player('X');
                //create console interface
                IConsole console = new ConsoleWrapper();
                Output output = new Output(console);
                //display welcome message
                Colors(ConsoleColor.Green, message.WelcomeMassage);
                //display game board
                output.DisplayArray(board.GameBoard);
                //display Game Instruction
                Colors(ConsoleColor.Green, message.GameInstruction);
                //display default Player turn
                Colors(ConsoleColor.Yellow, $"Its Player {player.Symbol}'s Turn.");
                //create Loop Instance
                GameLoop gameLoop = new GameLoop();

                gameLoop.Loop(board, validate, player, output, message);

                string answer = Console.ReadLine();

                if (board.PlayAgain(answer))
                {
                    continue;
                }
                return;
            }
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
