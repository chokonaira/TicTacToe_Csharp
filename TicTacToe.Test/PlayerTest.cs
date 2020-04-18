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
        }
    }
