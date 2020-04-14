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
            Helpers helper = new Helpers();
            int[] positions = { 0, 4, 8 };
            char[] symbols = { 'x', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin('x');
            Assert.True(actual);

        }

        [Fact]
        public void CheckBoardForVerticalWin()
        {
            Board board = new Board(3);
            Helpers helper = new Helpers();
            int[] positions = { 1, 4, 7 };
            char[] symbols = { 'o', 'o', 'o' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin('o');
            Assert.True(actual);
        }

        [Fact]
        public void CheckBoardForDiagonalWin()
        {
            Board board = new Board(3);
            Helpers helper = new Helpers();
            int[] positions = { 2, 4, 6 };
            char[] symbols = { 'x', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin('x');
            Assert.True(actual);

        }

        [Fact]
        public void CheckBoardForSecondDiagonalWin()
        {
            Board board = new Board(3);
            Helpers helper = new Helpers();
            int[] positions = { 0, 4, 8 };
            char[] symbols = { 'x','x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckWin('x');
            Assert.True(actual);
        }

        [Fact]
        public void CheckForActualDraw()
        {
            Board board = new Board(3);
            Helpers helper = new Helpers();
            int[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'o', 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckDraw('x', 'o');
            Assert.True(actual);
        }

        [Fact]
        public void FalseDrawIfWin()
        {
            Board board = new Board(3);
            Helpers helper = new Helpers();
            int[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'x', 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckDraw('x', 'o');
            Assert.False(actual);
        }


        [Fact]
        public void FalseDrawIfBoardHasAvailableMoves()
        {
            Board board = new Board(3);
            Helpers helper = new Helpers();
            int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            bool actual = board.CheckDraw('x', 'o');
            Assert.False(actual);
        }

        [Fact]
        public void ClearGameBoard()
        {
            Board board = new Board(3);
            Helpers helper = new Helpers();
            int[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'o', 'o', 'x', 'x', 'x', 'o', 'o', 'x', 'x' };
            helper.FillBoard(board, positions, symbols);
            board.InitializeBoard();
            char[] actual = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            Assert.Equal(board.GameBoard, actual);
        }
    }

   
}
