    using System;
    using Xunit;

    namespace TicTacToe.Test
    {
        public class PlayerTest
        {
            [Fact]
            public void InitializePlayerWithSYmbol_X()
            {
                Player player = new Player('X');
                char actual = player.Symbol;
                Assert.Equal('X',actual);
            }

            [Fact]
            public void InitializePlayerWithASYmbol_O()
            {
                Player player = new Player('O');
                char actual = player.Symbol;
                Assert.Equal('O', actual);
            }
            [Fact]
            public void CheckThatPlayerIsToggled()
            {
                Player player = new Player('X');
                player.TogglePlayer();
                Assert.Equal('O', player.Symbol);
            }
            //[Fact]
            //public void CheckWinnigPlayerX()
            //{
            //    var board = new Board(3);
            //    int[] positions = { 1, 5, 9 };
            //    char[] symbols = { 'X', 'X', 'X' };
            //    Helper.FillBoard(board, positions, symbols);
            //    bool actual = board.CheckWin();
            //    Assert.True(actual);

            //    Player player = new Player('X');
            //    player.WinningPlayer();
            //    Assert.Equal('X', player.WinningPlayer());
            //}
            //[Fact]
            //public void CheckWinnigPlayerO()
            //{
            //    var board = new Board(3);
            //    int[] positions = { 1, 5, 9 };
            //    char[] symbols = { 'O', 'O', 'O' };
            //    Helper.FillBoard(board, positions, symbols);
            //    bool actual = board.CheckWin();
            //    Assert.True(actual);

            //    Player player = new Player('O');
            //    player.WinningPlayer();
            //    Assert.Equal('O', player.WinningPlayer());
            //}
        }
    }
