using System;
using Xunit;

namespace TicTacToe.Test
{
    public class WelcomeTest
    {
        [Fact]
        public void SetWelcomeMessage()
        {
            Welcome game = new Welcome();

            string actual = game._welcomeMassage;
            string expected = "Welcome to Tic Tac Toe!";

            Assert.Equal(expected, actual);
        }
    }
}
