using System;

namespace TicTacToe
{
    public class Board
    {
        public char[] GameBoard { get; set; }

        public Board(int size)
        {
            GameBoard = new char[size * size];
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            for (int i = 0; i < GameBoard.Length; i++)
            {
                MakeMove(' ', i);
            }
        }
        public void MakeMove(char symbol, int position)
        {
            GameBoard[position] = symbol;
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

        public bool CheckDraw(char symbol1, char symbol2)
        {
            if (CheckWin(symbol1) || CheckWin(symbol2)) return false;
            if (GetAvailableMoves() > 0) return false;
            return true;
        }

    }
}
