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
            Message message = new Message();
            string actual = message.GameInstruction;
            string expected = "These are the different move positions you can make"; 

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetAWinMessage()
        {
            Message message = new Message();
            Player player = new Player('x');
            string actual = message.SetWinMessage(player.Symbol);
            string expected = "Congratulations player x has won!";

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PlayAgainMessage()
        {
            Message message = new Message();
            string actual = message.StartAgain;
            string expected = "Tap [Y] and enter to play again or Tap any key to quit";

            Assert.Equal(expected, actual);
        }
    }
}