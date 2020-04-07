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

            string actual = game.WelcomeMassage;
            string expected = "Welcome to Tic Tac Toe!";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetGameInstruction()
        {
            Welcome game = new Welcome();

            string actual = game.GameInstruction;
            string expected = "Use symbol X and O, In postion 1 to 9"; 

            Assert.Equal(expected, actual);
        }
    }
}
