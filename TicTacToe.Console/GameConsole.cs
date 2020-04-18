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
                Console.ForegroundColor = ConsoleColor.Green;
                output.DisplayString(message.WelcomeMassage);
                Console.ResetColor();
                //display game board
                output.DisplayArray(board.GameBoard);
                //display Game Instruction
                Console.ForegroundColor = ConsoleColor.Green;
                output.DisplayString(message.GameInstruction);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                output.DisplayString($"Its Player {player.Symbol}'s Turn.");
                Console.ResetColor();

                while (!board.CheckWin())
                {
                    string input = Console.ReadLine();

                    if (!validate.IsValid(board, input))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        output.DisplayString(validate.Message);
                        Console.ResetColor();
                        output.DisplayArray(board.GameBoard);
                        continue;
                    }

                    board.MakeMove(player.Symbol, int.Parse(input));
                    
                    output.DisplayArray(board.GameBoard);

                    if (board.CheckWin())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        output.DisplayString(message.SetWinMessage(player.Symbol));
                        Console.ResetColor();
                        break;
                    }
                    if (board.CheckDraw())
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        output.DisplayString(board.DrawMessage);
                        Console.ResetColor();
                        break;
                    }
                    player.TogglePlayer();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    output.DisplayString(message.ToggleMessage(player.Symbol));
                    Console.ResetColor();
                }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    output.DisplayString(message.StartAgain);
                    Console.ResetColor();

                    string answer = Console.ReadLine();
                    if (board.PlayAgain(answer))
                    {
                        continue;
                    }
                    return;
            }
        }
    }
}
