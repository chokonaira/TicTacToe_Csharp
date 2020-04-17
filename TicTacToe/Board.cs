using System;
using System.Linq;

namespace TicTacToe
{
    public class Board
    {
        public char[] GameBoard { get; set; }
        public string DrawMessage { get; set; }

        public Board(int size)
        {
            GameBoard = new char[size * size];
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            for (int i = 0; i < GameBoard.Length; i++)
            {
                MakeMove((char)(i + 1), i);
            }
        }
        public void MakeMove(char symbol, int position)
        {
            GameBoard[position] = symbol;
        }

        public int GetAvailableMoves() {
            return GameBoard.Where((t, i) => t == (char) (i + 1)).Count();
        }
        //x o -
        //- x o
        //- - x 

        public bool CheckWin()
        {
            return (GameBoard[0] == GameBoard[1] && GameBoard[1] == GameBoard[2]) ||
                   (GameBoard[3] == GameBoard[4] && GameBoard[4] == GameBoard[5]) ||
                   (GameBoard[6] == GameBoard[7] && GameBoard[7] == GameBoard[8]) ||
                   (GameBoard[0] == GameBoard[3] && GameBoard[3] == GameBoard[6]) ||
                   (GameBoard[1] == GameBoard[4] && GameBoard[4] == GameBoard[7]) ||
                   (GameBoard[2] == GameBoard[5] && GameBoard[5] == GameBoard[8]) ||
                   (GameBoard[0] == GameBoard[4] && GameBoard[4] == GameBoard[8]) ||
                   (GameBoard[2] == GameBoard[4] && GameBoard[4] == GameBoard[6]);
        }
        public bool CheckDraw()
        {
            DrawMessage = "Its a Draw!";
            return (GetAvailableMoves() == 0 && !CheckWin());
        }

        public bool PlayAgain(string input)
        {
            //_ = GameBoard;
            InitializeBoard();
            return (input.ToUpper() == "Y");
        }
    }
}