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
            Assert.Equal("Symbol must be x and o", validate.ErrorMessage);
            Assert.False(actual);
        }

        //[Fact]
        //public void WrongPlayerSymbolInteger()
        //{
        //    int symbol = 1;
        //    bool actual = validate.PlayerSymbol(symbol);
        //    Assert.Equal("Symbol must be x and o", validate.ErrorMessage);
        //    Assert.False(actual);
        //}

        [Fact]
        public void EmptyPlayerSymbol()
        {
            char symbol = ' ';
            bool actual = validate.PlayerSymbol(symbol);
            Assert.Equal("Symbol must be x and o", validate.ErrorMessage);
            Assert.False(actual);
        }
        [Fact]
        public void CorrectPlayerSymbol_x()
        {
            char symbol = 'x';
            bool actual = validate.PlayerSymbol(symbol);
            Assert.True(actual);
        }
        [Fact]
        public void CorrectPlayerSymbol_o()
        {
            char symbol = 'o';
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
            board.MakeMove('x', 0);
            bool actual = validate.CheckPosition(board.GameBoard, 0);
            Assert.Equal("Board position already occupied or out of range", validate.ErrorMessage);
            Assert.False(actual);
        }
        [Fact]
        public void CheckForEmptyPosition()
        {
            bool actual = validate.CheckPosition(board.GameBoard, 0);
            Assert.True(actual);
        }
        [Fact]
        public void CheckForMultipleEmptyPosition()
        {
            board.MakeMove('x', 0);
            board.MakeMove('x', 1);
            bool actual = validate.CheckPosition(board.GameBoard, 2);
            Assert.True(actual);
        }
        [Fact]
        public void CheckPositionOutOfRange()
        {
            board.MakeMove('x', 0);
            board.MakeMove('x', 1);
            bool actual = validate.CheckPosition(board.GameBoard, 10);
            Assert.Equal("Board position already occupied or out of range", validate.ErrorMessage);
            Assert.False(actual);
        }
        [Fact]
        public void CheckPositionLessThanRange()
        {
            board.MakeMove('x', 0);
            board.MakeMove('x', 1);
            bool actual = validate.CheckPosition(board.GameBoard, -1);
            Assert.Equal("Board position already occupied or out of range", validate.ErrorMessage);
            Assert.False(actual);
        }
    }
}
