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
        [Fact]
        public void CheckBoardForBestInitialMoveOnEmptyBoard()
        {

            Board board = new Board(3);
            int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            char[] symbols = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Minimax minimax = new Minimax('X', 'O');
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board);
            int expected = 1;

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void CheckBoardForBestMoveHorizonantal()
        {

            Board board = new Board(3);
            int[] positions = { 1, 2, 4, 5, 6, 7 };
            char[] symbols = { 'X', 'X', 'O', 'O', 'X', 'O' };
            Minimax minimax = new Minimax('X', 'O');
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board);
            int expected = 3;

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void CheckBoardForBestMoveVertical()
        {

            Board board = new Board(3);
            int[] positions = { 1, 2, 3, 4, 5, 6, 8 };
            char[] symbols = { 'X', 'O', 'O', 'X', 'O', 'X', 'O' };
            Minimax minimax = new Minimax('X', 'O');
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board);
            int expected = 7;

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void CheckBoardForBestMoveDiagonal()
        {

            Board board = new Board(3);
            int[] positions = { 1, 2, 3, 4, 5, 6, 9 };
            char[] symbols = { 'X', 'O', 'X', 'O', 'X', 'X', 'O' };
            Minimax minimax = new Minimax('X', 'O');
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board);
            int expected = 7;

            Assert.Equal(expected, actual);

        }
    }
}
