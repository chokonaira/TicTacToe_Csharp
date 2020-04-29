    using System;
using System.Collections.Generic;
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
            char symbol = '1';
            for (int position = 1; position <= GameBoard.Length; position++)
            {
                MakeMove(symbol++, position);
            }
        }

        public void MakeMove(char symbol, int position)
        {
            GameBoard[position - 1] = symbol;
        }

        public int GetAvailableMoves()
        {
            int counter = 0;
            char symbol = '1';
            for (int position = 0; position < GameBoard.Length; position++)
            {
                if (GameBoard[position] == symbol++)
                {
                    counter++;
                }
            }
            return counter;
        }

        public List<int> GetMovePositions()
        {
            char symbol = '1';
            List<int> emptyPositions = new List<int>();
            for (int position = 1; position <= GameBoard.Length; position++)
            {
                if (GameBoard[position - 1] == symbol)
                {
                    emptyPositions.Add(position);
                }
                symbol++;
            }
            return emptyPositions;
        }

        
        public char WinningPlayer()
        {
            if (GameBoard[0] == GameBoard[1] && GameBoard[1] == GameBoard[2])
                return GameBoard[0];
            if (GameBoard[3] == GameBoard[4] && GameBoard[4] == GameBoard[5])
                return GameBoard[3];
            if (GameBoard[6] == GameBoard[7] && GameBoard[7] == GameBoard[8])
                return GameBoard[6];
            if (GameBoard[0] == GameBoard[3] && GameBoard[3] == GameBoard[6])
                return GameBoard[0];
            if (GameBoard[1] == GameBoard[4] && GameBoard[4] == GameBoard[7])
                return GameBoard[1];
            if (GameBoard[2] == GameBoard[5] && GameBoard[5] == GameBoard[8])
                return GameBoard[2];
            if (GameBoard[0] == GameBoard[4] && GameBoard[4] == GameBoard[8])
                return GameBoard[0];
            if (GameBoard[2] == GameBoard[4] && GameBoard[4] == GameBoard[6])
                return GameBoard[2];
            return ' ';
        }
        public bool CheckDraw()
        {
            DrawMessage = "Its a Draw!";
            return GetAvailableMoves() == 0 && (WinningPlayer() == ' ');
        }

        public bool PlayAgain(string input)
        {
            InitializeBoard();
            return (input.ToUpper() == "Y");
        }
        public bool IsGameOver()
        {
            return !(WinningPlayer() == ' ') || CheckDraw();
        }

    }
}