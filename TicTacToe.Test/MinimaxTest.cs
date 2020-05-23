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
            Player player = new Player('X');
            Minimax minimax = new Minimax('X', 'O');
            int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8 };
            char[] symbols = { 'X', 'X', 'O', 'O', 'X', 'X', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board, player);
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
            Player player = new Player('X');
            Minimax minimax = new Minimax('X', 'O');
            int[] positions = { 1, 2, 4, 5, 6, 7, 8, 9 };
            char[] symbols = { 'X', 'X', 'O', 'X', 'X', 'X', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board, player);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        // O _ X
        // X _ X
        // X O O
        [Fact]
        public void CheckBoardForWinInMultipleOptions()
        {
            Board board = new Board(3);
            Player player = new Player('X');
            Minimax minimax = new Minimax('X', 'O');
            int[] positions = { 1, 3, 4, 6, 7, 8, 9 };
            char[] symbols = { 'O', 'X', 'X', 'X', 'X', 'O', 'O' };
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board, player);
            int expected = 5;
            Assert.Equal(expected, actual);
        }

        // O _ O
        // O X X
        // X _ O
        [Fact]
        public void CheckBoardForToBlockOpponentsWinningOption()
        {
            Board board = new Board(3);
            Player player = new Player('X');
            Minimax minimax = new Minimax('X', 'O');
            int[] positions = { 1, 3, 4, 5, 6, 7, 9 };
            char[] symbols = { 'O', 'O', 'O', 'X', 'X', 'X', 'O' };
            Helper.FillBoard(board, positions, symbols);
            int actual = minimax.FindBestMove(board, player);
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        // O _ O
        // O X X
        // X _ X
        [Fact]
        public void CheckBoardForWinningPositionForBothPlayers()
        {
           Board board = new Board(3);
           Player player = new Player('X');
           Minimax minimax = new Minimax('X', 'O');
           int[] positions = { 1, 3, 4, 5, 6, 7, 9 };
           char[] symbols = { 'O', 'O', 'O', 'X', 'X', 'X', 'X' };
           Helper.FillBoard(board, positions, symbols);
           int actual = minimax.FindBestMove(board, player);
           int expected = 8;
           Assert.Equal(expected, actual);
        }

        // _ _ _
        // _ _ _
        // _ _ _
        [Fact]
        public void CheckEmptyBoardForInitailOptimalMove()
        {
           Board board = new Board(3);
           Player player = new Player('X');
           Minimax minimax = new Minimax('X', 'O');;
           int actual = minimax.FindBestMove(board, player);
           //get available move on board
           int expected = 1;
           Assert.Equal(expected, actual);
        }

        // _ X O
        // _ _ X
        // O O X
        [Fact]
        public void CheckBoardForBestMoveThatMustResultToASubsiquentWinninMove()
        {
           Board board = new Board(3);
           Player player = new Player('X');
           int[] positions = { 2, 3, 6, 7,8,9 };
           char[] symbols = { 'X', 'O', 'X', 'O', 'O','X' };
           Minimax minimax = new Minimax('X', 'O');
           Helper.FillBoard(board, positions, symbols);
           int actual = minimax.FindBestMove(board, player);
           int expected = 5;

           Assert.Equal(expected, actual);

        }

        // X X O
        // 4 O 6
        // 7 8 9
        [Fact]
        public void CheckBoardForBestBlockingMove()
        {
           Board board = new Board(3);
           Player player = new Player('X');
           int[] positions = { 1, 2, 3, 5 };
           char[] symbols = { 'X', 'X', 'O', 'O' };
           Minimax minimax = new Minimax('X', 'O');
           Helper.FillBoard(board, positions, symbols);
           int actual = minimax.FindBestMove(board, player);
           int expected = 7;
           Assert.Equal(expected, actual);

        }
    }
}
