using System;

namespace TicTacToe
{
    public class Validation
    {
        public string ErrorMessage { get; set; }

        public bool PlayerSymbol(char symbol)
        {
            ErrorMessage = "Symbol must be x and o";
            return (char.ToLower(symbol) == 'x' || char.ToLower(symbol) == 'o');
        }

        public bool CheckPosition(char[] board, int position)
        {
            ErrorMessage = "Board position already occupied or out of range";

            return !(position > board.Length - 1 || position < 0) && (board[position] == ' ');

            //if (position > board.Length - 1 || position < 0) return false;
            //return (board[position] == ' ');
        }
    }
}
