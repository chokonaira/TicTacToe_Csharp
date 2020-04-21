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
                Message = "Symbol must be X and O";
                return (char.ToUpper(symbol) == 'X' || char.ToUpper(symbol) == 'O');
            }

            public bool IsValid(Board board, string input)
            {
                return CheckString(input) &&
                       CheckDigitRange(int.Parse(input)) &&
                       CheckBoardRange(board.GameBoard, int.Parse(input)) &&
                       CheckFreePosition(board.GameBoard, int.Parse(input));
            }

            public bool CheckDigitRange(int input)
            {
                Message = "Input must be between 1 to 9";
                IEnumerable<int> acceptedNumbers = Enumerable.Range(1, 10);
                return acceptedNumbers.Contains(input);
            }

            public bool CheckString(string input)
            {
                Message = "Please Enter an actual Number between 1 to 9";
                return (int.TryParse(input, out _));
            }

            public bool CheckBoardRange(char[] board, int position)
            {
                Message = "Position out of range";
                return (position <= board.Length && position >= 1);
            }
            public bool CheckFreePosition(char[] board, int position)
            {
                Message = "Position already occupied, choose another spot";
                return !(board[position -1] == 'X' || board[position-1] == 'O');
            }

            public bool CheckGameMode(string input)
            {
                int.TryParse(input, out int valid);
                Message = "Invalid option, please choose between option 1 or 2";
                return (valid == 1 || valid == 2);
            }
        }
    }
