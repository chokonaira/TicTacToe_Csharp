using System;
namespace TicTacToe
{
    public class Minimax
    {
        public char Player, Opponent;
        public Minimax(char player, char opponent)
        {
            Player = player;
            Opponent = opponent;
        }

        public int Evaluate(Board board)
        {
            if(board.WinningPlayer() == Player)
            {
                return +10;
            } else if (board.WinningPlayer() == Opponent)
            {
                return -10;
            }
            return 0;
        }

        public int Mini_max(Board board, int depth, bool isMax)
        {
            int score = Evaluate(board);

            if (score == 10)
                return score;
            if (score == -10)
                return score;
            if(board.CheckDraw())
                return 0;

            if (isMax)
            {
                int best = -1000;

                char symbol = '1';
                for (int position = 0; position < board.GameBoard.Length; position++)
                {
                    if (board.GameBoard[position] == symbol)
                    {
                        board.GameBoard[position] = Player;
                        best = Math.Max(best, Mini_max(board, depth + 1, !isMax));
                        board.GameBoard[position] = symbol;
                    }
                    symbol++;
                }
                return best;
            }
            else
            {
                int best = 1000;

                char symbol = '1';
                for (int position = 0; position < board.GameBoard.Length; position++)
                {
                    if (board.GameBoard[position] == symbol)
                    {
                        board.GameBoard[position] = Opponent;
                        best = Math.Min(best, Mini_max(board, depth + 1, !isMax));
                        board.GameBoard[position] = symbol;
                    }
                    symbol++;
                }
                return best;
            }
        }

        public int FindBestMove(Board board)
        {
            int bestVal = -1000;
            int bestMove = 0;

            char symbol = '1';
            for (int position = 0; position < board.GameBoard.Length; position++)
            {
                if (board.GameBoard[position] == symbol)
                {
                    board.GameBoard[position] = Player;
                    int moveVal = Mini_max(board, 0, false);
                    board.GameBoard[position] = symbol;
                    if (moveVal > bestVal)
                    {
                        bestMove = position + 1;
                        bestVal = moveVal;
                    }
                }
                symbol++;
            }
            return bestMove;
        }
    }

}