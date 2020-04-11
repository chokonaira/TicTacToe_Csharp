namespace TicTacToe.ConsoleGame
{
    public interface IConsole
    {
        void Write(string message);

        void WriteArray(char[] array);

        void WriteBool(bool message);

    }
}