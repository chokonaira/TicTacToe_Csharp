using System;
using System.Collections.Generic;
using System.Linq;

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
                return 10;
            } else if (board.WinningPlayer() == Opponent)
            {
                return -10;
            }
            return 0;
        }


        public int Mini_max(Board board)
        {
            List<int> scores = new List<int>();
            List<int> positions = new List<int>();

            //char board = Board.GetMovePositions();

            foreach (int position in board.GetMovePositions())
            {
                Board cloneBoard = new Board(3);
                for (int i = 0; i < board.GameBoard.Length; i++)
                {
                    cloneBoard.GameBoard[i] = board.GameBoard[i];
                }
                    
                int score = 0;
                Player player = new Player(AI);

                cloneBoard.MakeMove(player.Symbol, position);
                score = score + Evaluate(cloneBoard);
                player.TogglePlayer();

                if(score == 10)
                {
                    return position;
                }

                foreach (int rem_position in cloneBoard.GetMovePositions())
                {
                    cloneBoard.MakeMove(player.Symbol, rem_position);
                    score = score + Evaluate(cloneBoard);

                    player.TogglePlayer();

                }
                scores.Add(score);
                positions.Add(position);
            }
            
            int maxScore = scores.Max();
            int indexOfMaxScore = scores.IndexOf(maxScore);
            return positions[indexOfMaxScore];


        }

        public int FindBestMove(Board board)
        {
           return Mini_max(board);
        }
    }

}

