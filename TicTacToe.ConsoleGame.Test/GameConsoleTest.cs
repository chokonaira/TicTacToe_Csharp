using Moq;
using Xunit;

namespace TicTacToe.ConsoleGame.Test
{
    public class GameConsoleTest
    {
        [Fact]
        public void StubTheConsoleWriteBehaviour()
        {
            var message = "Stubing the console.write behaviour";
            var consoleMock = new Mock<IConsole>();
            consoleMock.Setup(c => c.Write(message));

            var output = new Output(consoleMock.Object);
            output.DisplayString(message);

            consoleMock.VerifyAll();
        }
    }
}
