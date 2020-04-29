using System;
using Xunit;

namespace TicTacToe.Test
{
    public class MinimaxTest
    {
        [Fact]
        public void CheckThatWinningPlayerEvaluatesForPlayer_X()
        {

            Board board = new Board(3);
            int[] positions = { 1, 5, 9 };
            char[] symbols = { 'X', 'X', 'X' };
            Minimax minimax = new Minimax('X', 'O');
            Helper.FillBoard(board, positions, symbols);
            board.WinningPlayer();
            int actual = minimax.Evaluate(board);

            Assert.Equal(10, actual);

        }
        [Fact]
        public void CheckThatWinningPlayerEvaluatesForPlayer_O()
        {

            Board board = new Board(3);
            int[] positions = { 1, 5, 9 };
            char[] symbols = { 'O', 'O', 'O' };
            Minimax minimax = new Minimax('X', 'O');
            Helper.FillBoard(board, positions, symbols);
            board.WinningPlayer();
            int actual = minimax.Evaluate(board);

            Assert.Equal(-10, actual);

        }
        [Fact]
        public void CheckThatWinningPlayerEvaluatesToZero()
        {

            Board board = new Board(3);
            int[] positions = { 1, 5, 9 };
            char[] symbols = { 'X', 'O', 'O' };
            Minimax minimax = new Minimax('X', 'O');
            Helper.FillBoard(board, positions, symbols);
            board.WinningPlayer();
            int actual = minimax.Evaluate(board);

            Assert.Equal(0, actual);

        }

        // X X O
        // O X X
        // O O -
        [Fact]
        public void CheckBoardForBestWinningMoveIndex9()
        {
            Board board = new Board(3);
            Minimax minimax = new Minimax('X', 'O');
            int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'X', 'X', 'O', 'O', 'X', 'X', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board);
            int expected = 9;
            Assert.Equal(expected, actual);
        }

        // X X -
        // O X X
        // X O O
        [Fact]
        public void CheckBoardForBestWinningMoveIndex3()
        {
            Board board = new Board(3);
            Minimax minimax = new Minimax('X', 'O');
            int[] positions = { 1, 2, 4, 5, 6, 7, 8, 9 };
            char[] symbols = { 'X', 'X', 'O', 'X', 'X', 'X', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        // O _ X
        // X _ X
        // X O O
        [Fact]
        public void CheckBoardForWinInMultiplePosition()
        {
            Board board = new Board(3);
            Minimax minimax = new Minimax('X', 'O');
            int[] positions = { 1, 3, 4, 6, 7, 8, 9 };
            char[] symbols = { 'O', 'X', 'X', 'X', 'X', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board);
            int expected = 5;
            Assert.Equal(expected, actual);
        }

        //[Fact]
        //public void CheckBoardForBestInitialMoveOnEmptyBoard()
        //{
        //    // 1 2 3
        //    // 4 5 6
        //    // 7 8 9
        //    Board board = new Board(3);
        //    int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    char[] symbols = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //    Minimax minimax = new Minimax('X', 'O');
        //    Helper.FillBoard(board, positions, symbols);
        //    int actual = minimax.FindBestMove(board);
        //    int expected = 1;

        //    Assert.Equal(expected, actual);

        //}
        //[Fact]
        //public void CheckBoardForBestMoveHorizonantal()
        //{
        //    // X X 3
        //    // O O X
        //    // O 8 9
        //    Board board = new Board(3);
        //    int[] positions = { 1, 2, 4, 5, 6, 7 };
        //    char[] symbols = { 'X', 'X', 'O', 'O', 'X', 'O' };
        //    Minimax minimax = new Minimax('X', 'O');
        //    Helper.FillBoard(board, positions, symbols);
        //    int actual = minimax.FindBestMove(board);
        //    int expected = 3;

        //    Assert.Equal(expected, actual);

        //}
        //[Fact]
        //public void CheckBoardForBestMoveVertical()
        //{
        //    // X O O
        //    // X O X
        //    // 7 8 9
        //    Board board = new Board(3);
        //    int[] positions = { 1, 2, 3, 4, 5, 6 };
        //    char[] symbols = { 'X', 'O', 'O', 'X', 'O', 'X' };
        //    Minimax minimax = new Minimax('X', 'O');
        //    Helper.FillBoard(board, positions, symbols);
        //    int actual = minimax.FindBestMove(board);
        //    int expected = 7;

        //    Assert.Equal(expected, actual);

        //}
        //[Fact]
        //public void CheckBoardForBestMoveDiagonal()
        //{
        //    // X O O
        //    // O X 6
        //    // X 8 9
        //    Board board = new Board(3);
        //    int[] positions = { 1, 2, 3, 4, 5, 7 };
        //    char[] symbols = { 'X', 'O', 'O', 'O', 'X', 'X' };
        //    Minimax minimax = new Minimax('X', 'O');
        //    Helper.FillBoard(board, positions, symbols);
        //    int actual = minimax.FindBestMove(board);
        //    int expected = 9;

        //    Assert.Equal(expected, actual);

        //}
        //[Fact]
        //public void CheckBoardForBestMove()
        //{
        //    // O 2 X
        //    // X 5 6
        //    // X O O
        //    Board board = new Board(3);
        //    int[] positions = { 1, 3, 4, 7, 8, 9 };
        //    char[] symbols = { 'O', 'X', 'X', 'X', 'O', 'O' };
        //    Minimax minimax = new Minimax('X', 'O');
        //    Helper.FillBoard(board, positions, symbols);
        //    int actual = minimax.FindBestMove(board);
        //    int expected = 5;

        //    Assert.Equal(expected, actual);

        //}
        //[Fact]
        //public void CheckBoardForBestMoveToBlock()
        //{
        //    // O O 3
        //    // X 5 6
        //    // X O O
        //    Board board = new Board(3);
        //    int[] positions = { 1, 2, 4, 7, 8, 9 };
        //    char[] symbols = { 'O', 'O', 'X', 'X', 'O', 'O' };
        //    Minimax minimax = new Minimax('X', 'O');
        //    Helper.FillBoard(board, positions, symbols);
        //    int actual = minimax.FindBestMove(board);
        //    int expected = 3;

        //    Assert.Equal(expected, actual);

        //}
        //[Fact]
        //public void CheckBoardForBestMoveToBlockButWin()
        //{
        //    // O O X
        //    // X X 6
        //    // 7 O O
        //    Board board = new Board(3);
        //    int[] positions = { 1, 2, 3, 4, 5, 8, 9 };
        //    char[] symbols = { 'O', 'O', 'X', 'X', 'X', 'O', 'O' };
        //    Minimax minimax = new Minimax('X', 'O');
        //    Helper.FillBoard(board, positions, symbols);
        //    int actual = minimax.FindBestMove(board);
        //    int expected = 6;

        //    Assert.Equal(expected, actual);

        //}
    }
}
