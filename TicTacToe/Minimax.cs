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
            // get move positions
            // loop through each move positiona nd make a move
            //s tore the score and the position
            foreach(int position in board.GetMovePositions())
            {
                board.MakeMove(AI, position);
                int score = Evaluate(board);
                scores.Add(score);
                positions.Add(position);
            }
            
            // get the index of the maximum score
            // using that index, get the move corresponding
            // that will be the best move
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

