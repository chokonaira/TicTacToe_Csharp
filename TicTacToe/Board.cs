﻿using System;

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
       
        public bool CheckWin(char Symbol)
        {
            return  (GameBoard[0] == Symbol && GameBoard[1] == Symbol && GameBoard[2] == Symbol) ||
                    (GameBoard[3] == Symbol && GameBoard[4] == Symbol && GameBoard[5] == Symbol) ||
                    (GameBoard[6] == Symbol && GameBoard[7] == Symbol && GameBoard[8] == Symbol) ||
                    (GameBoard[0] == Symbol && GameBoard[3] == Symbol && GameBoard[6] == Symbol) ||
                    (GameBoard[1] == Symbol && GameBoard[4] == Symbol && GameBoard[7] == Symbol) ||
                    (GameBoard[2] == Symbol && GameBoard[5] == Symbol && GameBoard[8] == Symbol) ||
                    (GameBoard[0] == Symbol && GameBoard[4] == Symbol && GameBoard[8] == Symbol) ||
                    (GameBoard[2] == Symbol && GameBoard[4] == Symbol && GameBoard[6] == Symbol);
        }

        public bool CheckDraw(char symbol_X, char symbol_O)
        {
            //find a way to return one statement 
            //if (CheckWin(symbol_X) || CheckWin(symbol_O)) return false;
            return (GetAvailableMoves() == 0 && !(CheckWin(symbol_X) || CheckWin(symbol_O)));
            //return true;
        }

    }
}
