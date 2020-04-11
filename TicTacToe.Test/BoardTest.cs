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
        public void CheckBoardForDraw()
        {
         
            Board board = new Board(3);
            char[] actual = board.positions;
            char[] expected = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Assert.Equal(expected, actual);
        }
        //[Fact]
        //public void SetPositionX()
        //{
        //    Board board = new Board();
        //    board.SetPositions(1, 'x');

        //    char[] actual = board.positions;
        //    char[] expected = { 'x', '2', '3', '4', '5', '6', '7', '8', '9' };

        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void SetPositionO()
        //{
        //    Board board = new Board();
        //    board.SetPositions(1, 'o');

        //    char[] actual = board.positions;
        //    char[] expected = { 'o', '2', '3', '4', '5', '6', '7', '8', '9' };

        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void SetPositionXinMiddle()
        //{
        //    Board board = new Board();
        //    board.SetPositions(2, 'x');

        //    char[] actual = board.positions;
        //    char[] expected = { '1', 'x', '3', '4', '5', '6', '7', '8', '9' };

        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void SetInitialBoard()
        //{
        //    Board board = new Board();
        //    string actual = board.GetBoard();
        //    string expected = "     |     |     \n" +
        //                      "  1  |  2  |  3\n" +
        //                      "_____|_____|_____\n" +
        //                      "     |     |     \n" +
        //                      "  4  |  5  |  6\n" +
        //                      "_____|_____|_____\n" +
        //                      "     |     |     \n" +
        //                      "  7  |  8  |  9\n" +
        //                      "     |     |     \n";

        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void GetBoardWithPositionX()
        //{
        //    Board board = new Board();
        //    board.SetPositions(1, 'x');
        //    string actual = board.GetBoard();
        //    string expected = "     |     |     \n" +
        //                      "  x  |  2  |  3\n" +
        //                      "_____|_____|_____\n" +
        //                      "     |     |     \n" +
        //                      "  4  |  5  |  6\n" +
        //                      "_____|_____|_____\n" +
        //                      "     |     |     \n" +
        //                      "  7  |  8  |  9\n" +
        //                      "     |     |     \n";

        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void GetBoardWithAllPositions()
        //{
        //    Board board = new Board();
        //    board.SetPositions(1, 'x');
        //    board.SetPositions(2, 'o');
        //    board.SetPositions(3, 'x');
        //    board.SetPositions(4, 'o');
        //    board.SetPositions(5, 'x');
        //    board.SetPositions(6, 'o');
        //    board.SetPositions(7, 'x');
        //    board.SetPositions(8, 'o');
        //    board.SetPositions(9, 'x');
        //    string actual = board.GetBoard();
        //    string expected = "     |     |     \n" +
        //                      "  x  |  o  |  x\n" +
        //                      "_____|_____|_____\n" +
        //                      "     |     |     \n" +
        //                      "  o  |  x  |  o\n" +
        //                      "_____|_____|_____\n" +
        //                      "     |     |     \n" +
        //                      "  x  |  o  |  x\n" +
        //                      "     |     |     \n";

        //    Assert.Equal(expected, actual);
        //}
    }
}
