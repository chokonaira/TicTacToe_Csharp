using System;

namespace TicTacToe
{
    public class Board
    {
        public char[] GameBoard { get; set; }
        //public char[] positions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Board(int size)
        {
            GameBoard = new char[size * size];
            DisplayBoard();
        }

        public void MakeMove(char symbol, int position)
        {
            GameBoard[position] = symbol;
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < GameBoard.Length; i++)
            {
                MakeMove(' ', i);
            }
        }

        public int GetAvailableMoves()
        {
            int counter = 0;
            for(int i = 0; i < GameBoard.Length; i++)
            {
                if(GameBoard[i] == ' ')
                {
                    counter++;
                }
            }
            return counter;
        }
        //check for available spots and returns an int<< the state of the board
        //once i make a move
        //number of available spots will change
        //evrytime u make a move, i will check if the
        //

        //val Gamboard[0]
        //[0, 1, 2]
        //[3, 4, 5]
        //[6, 7, 8]
        public bool CheckWin(char symbol)
        {
            return  (GameBoard[0] == symbol && GameBoard[1] == symbol && GameBoard[2] == symbol) ||
                    (GameBoard[3] == symbol && GameBoard[4] == symbol && GameBoard[5] == symbol) ||
                    (GameBoard[6] == symbol && GameBoard[7] == symbol && GameBoard[8] == symbol) ||
                    (GameBoard[0] == symbol && GameBoard[3] == symbol && GameBoard[6] == symbol) ||
                    (GameBoard[1] == symbol && GameBoard[4] == symbol && GameBoard[7] == symbol) ||
                    (GameBoard[2] == symbol && GameBoard[5] == symbol && GameBoard[8] == symbol) ||
                    (GameBoard[0] == symbol && GameBoard[4] == symbol && GameBoard[8] == symbol) ||
                    (GameBoard[2] == symbol && GameBoard[4] == symbol && GameBoard[6] == symbol);

        }



        //public void SetPositions(int num, char value)
        //{
        //    positions[num - 1] = value;
        //}

        //public string GetBoard()
        //{
        //    return String.Format(EmptyBoard,
        //         positions[0],
        //         positions[1],
        //         positions[2],
        //         positions[3],
        //         positions[4],
        //         positions[5],
        //         positions[6],
        //         positions[7],
        //         positions[8]);
        //}

    }
}
