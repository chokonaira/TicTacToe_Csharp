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
            Helper.FillBoard(board, positions, symbols);
            board.WinningPlayer();
            int actual = Minimax.Evaluate(board);

            Assert.Equal(10, actual);

        }
        [Fact]
        public void CheckThatWinningPlayerEvaluatesForPlayer_O()
        {

            Board board = new Board(3);
            int[] positions = { 1, 5, 9 };
            char[] symbols = { 'O', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            board.WinningPlayer();
            int actual = Minimax.Evaluate(board);

            Assert.Equal(-10, actual);

        }
        [Fact]
        public void CheckThatWinningPlayerEvaluatesToZero()
        {

            Board board = new Board(3);
            int[] positions = { 1, 5, 9 };
            char[] symbols = { 'X', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            board.WinningPlayer();
            int actual = Minimax.Evaluate(board);

            Assert.Equal(0, actual);

        }
    }
}
