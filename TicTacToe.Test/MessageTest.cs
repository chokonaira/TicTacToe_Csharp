using System;
using Xunit;

namespace TicTacToe.Test
{
    public class WelcomeTest
    {
        [Fact]
        public void SetWelcomeMessage()
        {
            Message game = new Message();

            string actual = game.WelcomeMassage;
            string expected = "Welcome to Tic Tac Toe!";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetGameInstruction()
        {
            Message game = new Message();

            string actual = game.GameInstruction;
            string expected = "These are the different move positions you can make"; 

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetWinMessage()
        {
            Message game = new Message();
            Player player = new Player('x');
            string actual = game.SetWinMessage(player.Symbol);
            string expected = "Congratulations player x has won!";

            Assert.Equal(expected, actual);
        }
    }
}
