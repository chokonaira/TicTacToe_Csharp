using System;

namespace TicTacToe.ConsoleGame
{
    public class Output
    {
        private IConsole _console = new ConsoleWrapper();

        public Output(IConsole console)
        {
            _console = console;
        }

        public void DisplayString(string message)
        {
            _console.Write(message);
        }

        public void DisplayArray(char[] message)
        {
            _console.WriteArray(message);
        }
    }
}
