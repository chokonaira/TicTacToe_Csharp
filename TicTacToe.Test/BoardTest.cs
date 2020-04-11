using System;
using Xunit;

namespace TicTacToe.Test
{
    public class BoardTest
    {
        [Fact]
        public void SpecifyGameBoardSIze()
        {
            Board board = new Board(3);
            int actual = board.GameBoard.Length;
            Assert.Equal(9, actual);
        }

        [Fact]
        public void CheckForMoveOnBoardX()
        {
            Board board = new Board(3);
            board.MakeMove('x',0);
            char expected = 'x';
            Assert.Equal(expected, board.GameBoard[0]);
        }

        [Fact]
        public void CheckForMoveOnBoardO()
        {
            Board board = new Board(3);
            board.MakeMove('o', 0);
            char expected = 'o';
            Assert.Equal(expected, board.GameBoard[0]);
        }

        [Fact]
        public void CheckForAvailableMoves()
        {
            Board board = new Board(3);
            int expected = 9;
            Assert.Equal(expected, board.GetAvailableMoves());
           
        }

        [Fact]
        public void CheckBoardForValidMove()
        {
            Board board = new Board(3);
            board.MakeMove('o', 0);
            int expected = 8;
            Assert.Equal(expected, board.GetAvailableMoves());
        }

        [Fact]
        public void CheckBoardForHorizontalWin()
        {
            Board board = new Board(3);
            board.GameBoard[0] = 'x';
            board.GameBoard[1] = 'x';
            board.GameBoard[2] = 'x';
            bool actual = board.CheckWin('x');
            Assert.True(actual);

        }

        [Fact]
        public void CheckBoardForVerticalWin()
        {
            Board board = new Board(3);
            board.GameBoard[1] = 'o';
            board.GameBoard[4] = 'o';
            board.GameBoard[7] = 'o';
            bool actual = board.CheckWin('o');
            Assert.True(actual);
        }

        [Fact]
        public void CheckBoardForDiagonalWin()
        {
            Board board = new Board(3);
            board.GameBoard[2] = 'x';
            board.GameBoard[4] = 'x';
            board.GameBoard[6] = 'x';
            bool actual = board.CheckWin('x');
            Assert.True(actual);

        }

        [Fact]
        public void CheckBoardForSecondDiagonalWin()
        {
            Board board = new Board(3);
            board.GameBoard[0] = 'x';
            board.GameBoard[4] = 'x';
            board.GameBoard[8] = 'x';
            bool actual = board.CheckWin('x');
            Assert.True(actual);
        }

        [Fact]
        public void CheckForActualDraw()
        {
            Board board = new Board(3);
            // o o x
            // x x o
            // o x x
            board.GameBoard[0] = 'o';
            board.GameBoard[1] = 'o';
            board.GameBoard[2] = 'x';
            board.GameBoard[3] = 'x';
            board.GameBoard[4] = 'x';
            board.GameBoard[5] = 'o';
            board.GameBoard[6] = 'o';
            board.GameBoard[7] = 'x';
            board.GameBoard[8] = 'x';
            bool actual = board.CheckDraw('x', 'o');
            Assert.True(actual);
        }

        [Fact]
        public void FalseDrawIfWin()
        {
            Board board = new Board(3);
            // x o x
            // x x o
            // o x x
            board.GameBoard[0] = 'x';
            board.GameBoard[1] = 'o';
            board.GameBoard[2] = 'x';
            board.GameBoard[3] = 'x';
            board.GameBoard[4] = 'x';
            board.GameBoard[5] = 'o';
            board.GameBoard[6] = 'o';
            board.GameBoard[7] = 'x';
            board.GameBoard[8] = 'x';
            bool actual = board.CheckDraw('x', 'o');
            Assert.False(actual);
        }

        [Fact]
        public void FalseDrawIfBoardHasAvailableMoves()
        {
            Board board = new Board(3);
            // - o x
            // x x o
            // o x x
            board.GameBoard[1] = 'o';
            board.GameBoard[2] = 'x';
            board.GameBoard[3] = 'x';
            board.GameBoard[4] = 'x';
            board.GameBoard[5] = 'o';
            board.GameBoard[6] = 'o';
            board.GameBoard[7] = 'x';
            board.GameBoard[8] = 'x';
            bool actual = board.CheckDraw('x', 'o');
            Assert.False(actual);
        }
    }
}
