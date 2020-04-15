using System;
using Xunit;

namespace TicTacToe.Test
{
    public class PlayerTest
    {
        [Fact]
        public void InitializePlayerWithSYmbol_X()
        {
            Player player = new Player('x');
            char actual = player.Symbol;
            Assert.Equal('x',actual);
        }

        [Fact]
        public void InitializePlayerWithASYmbol_O()
        {
            Player player = new Player('o');
            char actual = player.Symbol;
            Assert.Equal('o', actual);
        }
        [Fact]
        public void CheckThatPlayerIsToggled()
        {
            Player player = new Player('x');
            player.TogglePlayer();
            Assert.Equal('o', player.Symbol);
        }
    }
}
