using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public class Validation
    {
        public string Message { get; set; }

        public bool PlayerSymbol(char symbol)
        {
            Message = "Symbol must be x and o";
            return (char.ToLower(symbol) == 'x' || char.ToLower(symbol) == 'o');
        }

        public bool CheckDigitRange(int input)
        {
            Message = "Input must be between 0 to 9";
            IEnumerable<int> acceptedNumbers = Enumerable.Range(0, 10);
            return acceptedNumbers.Contains(input);
        }

        public bool CheckString(string input)
        {
            Message = "Please Enter an actual Number between 0 to 9";
            return (!int.TryParse(input, out _));
        }

        public bool CheckBoardRange(char[] board, int position)
        {
            Message = "Position out of range";
            return (position <= board.Length - 1 && position >= 0);
        }
        public bool CheckFreePosition(char[] board, int position)
        {
            Message = "Position already occupied, choose another spot";
            return (board[position] == Convert.ToChar(position + 1));
        }
    }
}
