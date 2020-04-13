using System;

namespace TicTacToe
{
    public class Validation
    {
        public bool PlayerSymbol(char symbol)
        {
            return (char.ToLower(symbol) == 'x' || char.ToLower(symbol) == 'o');
        }

        public bool CheckPosition(char[] board, int position)
        {
            if (position > board.Length - 1 || position < 0) return false;
            return (board[position] == ' ');
        }
    }
}
