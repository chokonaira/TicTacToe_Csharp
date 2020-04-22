using System;
namespace TicTacToe
{
    public class Minimax
    {
        public char Computer, Human;
        public Minimax(char player, char opponent)
        {
            Computer = player;
            Human = opponent;
        }

        // Returns a value based on who is winning
        public int Evaluate(Board board)
        {
            if(board.WinningPlayer() == Computer)
            {
                return +10;

            } else if (board.WinningPlayer() == Human)
            {
                return -10;
            }
            // Else if none of them have won then return 0
            return 0;
        }

        public int Mini_max(Board board, int depth, bool isMax)
        {
            int score = Evaluate(board);

            if (score == 10)
                return score;

            if (score == -10)
                return score;

            if(board.GetAvailableMoves() == 0)
                return 0;

            // If this maximizer's move 
            if (isMax)
            {
                int best = -1000;

                char symbol = '1';
                for (int position = 0; position < board.GameBoard.Length; position++)
                {
                     // Check if cell is empty
                    if (board.GameBoard[position] == symbol)
                    {
                        // Make the move 
                        board.GameBoard[position] = Computer;

                        // Call minimax recursively and choose 
                        // the maximum value
                        best = Math.Max(best, Mini_max(board, depth + 1, !isMax));
                        // Undo the move
                        board.GameBoard[position] = symbol;
                    }
                    symbol++;
                }
                return best;
            }

            // If this minimizer's move 
            else
            {
                int best = 1000;

                char symbol = '1';
                for (int position = 0; position < board.GameBoard.Length; position++)
                {
                    // Check if cell is empty
                    if (board.GameBoard[position] == symbol)
                    {
                        // Make the move
                        board.GameBoard[position] = symbol;
                        // the maximum value
                        best = Math.Min(best, Mini_max(board, depth + 1, !isMax));

                        // Undo the move
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
                // Check if cell is empty
                if (board.GameBoard[position] == symbol)
                {
                    // Make the move 
                    board.GameBoard[position] = Computer;

                    // compute evaluation function for this 
                    // move. 
                    int moveVal = Mini_max(board, 0, false);

                    // Undo the move
                    board.GameBoard[position] = symbol;

                    // If the value of the current move is
                    // more than the best value, then update 
                    // best/ 
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