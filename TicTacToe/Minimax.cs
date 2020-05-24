using System;

namespace TicTacToe
{
    public class Minimax
    {
        public char AI, Opponent;
        public Minimax(char ai, char opponent)
        {
            AI = ai;
            Opponent = opponent;
        }

        public int Evaluate(Board board, int depth = 0)
        {
            if(board.WinningPlayer() == AI)
            {
                return 10 - depth;
            } else if (board.WinningPlayer() == Opponent)
            {
                return depth - 10;
            }
            return 0;
        }

         public int Mini_max(Board board, Player player, int depth)
        {
            int score = Evaluate(board, depth);

            if (score != 0)
                return score;

            if(board.CheckDraw())
                return 0;

            if (player.Symbol == AI)
            {
                int best = -1000;
                foreach (int position in board.GetMovePositions())
                {
                    char symbol = board.GetSymbol(position);
                    MoveTogglePlayer(board, AI, position, player);
                    best = Math.Max(best, Mini_max(board, player, depth + 1));
                    MoveTogglePlayer(board, symbol, position, player);
                }
                return best;
            }
            else
            {
                int best = 1000;
                foreach (int position in board.GetMovePositions())
                {
                    char symbol = board.GetSymbol(position);
                    MoveTogglePlayer(board, Opponent, position, player);
                    best = Math.Min(best, Mini_max(board, player, depth + 1));
                    MoveTogglePlayer(board, symbol, position, player);
                }
                return best;
            }
        }

        public void MoveTogglePlayer(Board board, char symbol, int position, Player player)
        {
            board.MakeMove(symbol, position);
            player.TogglePlayer();
        }

        public int FindBestMove(Board board, Player player)
        {
            int bestVal = -1000;
            int bestMove = 0;
            foreach (int position in board.GetMovePositions())
            {
                char symbol = board.GetSymbol(position);
                MoveTogglePlayer(board, AI, position, player);
                int moveVal = Mini_max(board, player, 0);
                MoveTogglePlayer(board, symbol, position, player);
                if (moveVal > bestVal)
                {
                    bestMove = position;
                    bestVal = moveVal;
                }
            }
            return bestMove;
        }
    }
}

