using System;
namespace TicTacToe.ConsoleGame
{
    public class GameLoop
    {
        public void Loop(Board board, Validation validate, Player player, Output output, Message message, Minimax minimax, int mode)
        {
            while (!board.IsGameOver())
            {
                string input;
                if(mode == 2 && player.Symbol == minimax.AI) {

                    input = minimax.FindBestMove(board, player).ToString();
                }
                else
                {
                    input = Console.ReadLine();
                    if (!validate.IsValid(board, input.ToString()))
                    {
                        GameConsole.Colors(ConsoleColor.Red, validate.Message);
                        output.DisplayArray(board.GameBoard);
                        continue;
                    }

                }

                board.MakeMove(player.Symbol, int.Parse(input));
                
                output.DisplayArray(board.GameBoard);

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
