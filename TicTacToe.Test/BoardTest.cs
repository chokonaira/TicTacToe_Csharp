using System;
using Xunit;

namespace TicTacToe.Test
{
    internal class Helpers
    {
        public void FillBoard(Board board, int[] positions, char[] symbols)
        {
            for (int i = 0; i < positions.Length; i++)
            {
                board.MakeMove(symbols[i], positions[i]);
            }
        }
    }

    public class BoardTest
    {
        readonly Board board;

        public BoardTest()
        {
            board = new Board(3);
            Console.WriteLine("GameBoard1");
            Console.WriteLine(board);
            
            board.InitializeBoard();
            Console.WriteLine("GameBoard2");
            Console.WriteLine(board);
        }
        

        [Fact]
        public void SpecifyGameBoardSIze()
        {
            int actual = board.GameBoard.Length;
            Assert.Equal(9, actual);
        }

        [Fact]
        public void CheckForMoveOnBoardX()
        {
            board.MakeMove('x',0);
            char expected = 'x';
            Assert.Equal(expected, board.GameBoard[0]);
        }

        [Fact]
        public void CheckForMoveOnBoardO()
        {
            board.MakeMove('o', 0);
            char expected = 'o';
            Assert.Equal(expected, board.GameBoard[0]);
        }

        [Fact]
        public void CheckForAvailableMoves()
        {
            int expected = 9;
            Assert.Equal(expected, board.GetAvailableMoves());
        }

        [Fact]
        public void CheckBoardForValidMove()
        {
            board.MakeMove('o', 0);
            int expected = 8;
            Assert.Equal(expected, board.GetAvailableMoves());
        }

        [Fact]
        public void CheckBoardForHorizontalWin()
        {
            Helpers helper = new Helpers();
            int[] positions = { 0, 4, 8 };
            char[] symbols = { 'x', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin();
            Assert.True(actual);

        }

        [Fact]
        public void CheckBoardForVerticalWin()
        {
            Helpers helper = new Helpers();
            int[] positions = { 1, 4, 7 };
            char[] symbols = { 'o', 'o', 'o' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin();
            Assert.True(actual);
        }

        [Fact]
        public void CheckBoardForDiagonalWin()
        {
            Helpers helper = new Helpers();
            int[] positions = { 2, 4, 6 };
            char[] symbols = { 'x', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin();
            Assert.True(actual);

        }

        [Fact]
        public void CheckBoardForSecondDiagonalWin()
        {
            Helpers helper = new Helpers();
            int[] positions = { 0, 4, 8 };
            char[] symbols = { 'x','x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin();
            Assert.True(actual);
        }

        [Fact]
        public void CheckForActualDraw()
        {
            Helpers helper = new Helpers();
            int[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'o', 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckDraw();

            Assert.Equal("Its a Draw!", board.DrawMessage);
            Assert.True(actual);
        }

        [Fact]
        public void FalseDrawIfWin()
        {
            Helpers helper = new Helpers();
            int[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'x', 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckDraw();
            Assert.False(actual);
        }


        [Fact]
        public void FalseDrawIfBoardHasAvailableMoves()
        {
            Helpers helper = new Helpers();
            int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckDraw();
            Assert.False(actual);
        }

        [Fact]
        public void ClearGameBoard()
        {
            //Arrange
            Helpers helper = new Helpers();
            int[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'o', 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            board.InitializeBoard();
            char[] expected = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //Act
            var actual = board.GameBoard;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}