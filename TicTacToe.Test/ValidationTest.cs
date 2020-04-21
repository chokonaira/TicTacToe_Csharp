    using System;
    using Xunit;

    namespace TicTacToe.Test
    {
        public class ValidationTest
        {
            readonly Validation validate;
            readonly Board board;

            public ValidationTest()
            {
                validate = new Validation();
                board = new Board(3);
            }

            [Fact]
            public void WrongPlayerSymbolAlphabet()
            {
                char symbol = 'a';
                bool actual = validate.PlayerSymbol(symbol);
                Assert.Equal("Symbol must be X and O", validate.Message);
                Assert.False(actual);
            }

            [Fact]
            public void CheckDigitWithinRange()
            {
                int input = 1;
                bool actual = validate.CheckDigitRange(input);
                Assert.Equal("Input must be between 1 to 9", validate.Message);
                Assert.True(actual);
            }
            [Fact]
            public void CheckDigitAboveRange()
            {
                int input = 15;
                bool actual = validate.CheckDigitRange(input);
                Assert.Equal("Input must be between 1 to 9", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void CheckDigitsBelowRange()
            {
                int input = -1;
                bool actual = validate.CheckDigitRange(input);
                Assert.Equal("Input must be between 1 to 9", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void CheckForStringInput()
            {
                string position = "hello";
                bool actual = validate.CheckString(position);
                Assert.Equal("Please Enter an actual Number between 1 to 9", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void CheckForSpecialCharacterInput()
            {
                string position = "#&$^%^#&";
                bool actual = validate.CheckString(position);
                Assert.Equal("Please Enter an actual Number between 1 to 9", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void CheckForEmptyInput()
            {
                string position = " ";
                bool actual = validate.CheckString(position);
                Assert.Equal("Please Enter an actual Number between 1 to 9", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void EmptyPlayerSymbol()
            {
                char symbol = ' ';
                bool actual = validate.PlayerSymbol(symbol);
                Assert.Equal("Symbol must be X and O", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void CorrectPlayerSymbol_x()
            {
                char symbol = 'X';
                bool actual = validate.PlayerSymbol(symbol);
                Assert.True(actual);
            }
            [Fact]
            public void CorrectPlayerSymbol_o()
            {
                char symbol = 'O';
                bool actual = validate.PlayerSymbol(symbol);
                Assert.True(actual);
            }
            [Fact]
            public void CorrectPlayerSymbolCapitalLetters()
            {
                Validation validate = new Validation();
                char symbol = 'O';
                bool actual = validate.PlayerSymbol(symbol);
                Assert.True(actual);
            }
            [Fact]
            public void CheckForOccupiedPosition()
            {
                board.MakeMove('X', 1);
                bool actual = validate.CheckFreePosition(board.GameBoard, 1);
                Assert.Equal("Position already occupied, choose another spot", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void CheckForEmptyPosition()
            {
                bool actual = validate.CheckFreePosition(board.GameBoard, 1);
                Assert.True(actual);
            }
            [Fact]
            public void CheckForMultipleEmptyPosition()
            {
                board.MakeMove('X', 1);
                board.MakeMove('X', 2);
                bool actual = validate.CheckFreePosition(board.GameBoard, 3);
                Assert.True(actual);
            }
            [Fact]
            public void CheckPositionOutOfRange()
            {
                board.MakeMove('X', 1);
                board.MakeMove('X', 2);
                bool actual = validate.CheckBoardRange(board.GameBoard, 11);
                Assert.Equal("Position out of range", validate.Message);
                Assert.False(actual);
            }
            [Fact]
            public void CheckPositionLessThanRange()
            {
                board.MakeMove('X', 1);
                board.MakeMove('X', 2);
                bool actual = validate.CheckBoardRange(board.GameBoard, 0);
                Assert.Equal("Position out of range", validate.Message);
                Assert.False(actual);
            }
        }
    }
