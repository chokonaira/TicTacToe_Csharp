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

        public int Evaluate(Board board)
        {
            if(board.WinningPlayer() == AI)
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

            if (board.CheckDraw())
                return 0;
            if (isMax)
            {
                int best = -1000;

                // getAvailableMopves array
                // loop through the available moves
                // makemoves


                char symbol = '1';
                for (int position = 1; position <= board.GetMovePositions().Count; position++)
                {
                    if (board.GameBoard[position - 1] == symbol)
                    {
                        board.MakeMove(AI, position);
                        best = Math.Max(best, Mini_max(board, depth + 1, !isMax));
                        board.MakeMove(symbol, position);
                    }
                    symbol++;
                }
                return best;
            }
            else
            {
                int best = 1000;

                char symbol = '1';
                for (int position = 1; position <= board.GetMovePositions().Count; position++)
                {
                    if (board.GameBoard[position - 1] == symbol)
                    {
                        board.MakeMove(Opponent, position);
                        best = Math.Min(best, Mini_max(board, depth + 1, !isMax));
                        board.MakeMove(symbol, position);
                    }
                    symbol++;
                }
                return best;
            }
        }

        public int FindBestMove(Board board)
        {
            int bestScore = -1000;

            int bestMove = 0;

            char symbol = '1';
            for (int position = 0; position < board.GetMovePositions().Count; position++)
            {
                if (board.GameBoard[position] == symbol)
                {
                    board.GameBoard[position] = AI;
                    int score = Mini_max(board, 0, false);
                    board.GameBoard[position] = symbol;
                    if (score > bestScore)
                    {
                        bestMove = position + 1;
                        bestScore = score;
                    }
                }
                symbol++;
            }
            return bestMove;
        }
    }

}

