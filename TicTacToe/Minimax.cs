using System;
namespace TicTacToe
{
    public class Minimax
    {
        // Returns a value based on who is winning
        public static int Evaluate(Board board)
        {
            if(board.WinningPlayer() == 'X')
            {
                return +10;

            } else if (board.WinningPlayer() == 'O')
            {
                return -10;
            }
            // Else if none of them have won then return 0
            return 0;
        }

        public static int Mini_max(Board board, int depth, bool isMax)
        {
            int score = Evaluate(board);

            if (score == 10)
                return score;

            if (score == -10)
                return score;
            if(board.GetAvailableMoves() == 0)
                return 0;

            if (isMax)
            {
                int best = -1000;

                char symbol = '1';
                for (int position = 0; position < board.GameBoard.Length; position++)
                {
                    if (board.GameBoard[position] == symbol++)
                    {
                        board.GameBoard[position] = 'X';

                        best = Math.Max(best, Mini_max(board,
                                    depth + 1, !isMax));

                        board.GameBoard[position] = symbol;
                    }
                }
                return best;

            }
            else
            {
                int best = 1000;

                char symbol = '1';
                for (int position = 0; position < board.GameBoard.Length; position++)
                {
                    if (board.GameBoard[position] == symbol++)
                    {
                        board.GameBoard[position] = 'O';

                        best = Math.Min(best, Mini_max(board,
                                    depth + 1, !isMax));

                        board.GameBoard[position] = symbol;
                    }
                }
                return best;
            }
        }
    }

}