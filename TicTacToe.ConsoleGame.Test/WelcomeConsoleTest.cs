using System;
using Xunit;

namespace TicTacToe.ConsoleGame.Test
{
    public class WelcomeConsoleTest
    {
        [Fact]
        public void DisplayWelcomeMessage()
        {
            Welcome game = new Welcome();
            string[] args = { };
            WelcomeConsole.Main(args);
            string actual = game._welcomeMassage;
            string expected = "Welcome to Tic Tac Toe!";

            Assert.Equal(expected, actual);
        }
    }
}
