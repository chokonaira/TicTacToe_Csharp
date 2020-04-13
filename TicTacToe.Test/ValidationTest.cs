using System;
using Xunit;

namespace TicTacToe.Test
{
    public class ValidationTest
    {
        [Fact]
        public void WrongPlayerSymbol()
        {
            Validation validate = new Validation();
            char symbol = 'a';
            bool actual = validate.PlayerSymbol(symbol);
            Assert.False(actual);
        }

        [Fact]
        public void EmptyPlayerSymbol()
        {
            Validation validate = new Validation();
            char symbol = ' ';
            bool actual = validate.PlayerSymbol(symbol);
            Assert.False(actual);
        }
        [Fact]
        public void CorrectPlayerSymbol_x()
        {
            Validation validate = new Validation();
            char symbol = 'x';
            bool actual = validate.PlayerSymbol(symbol);
            Assert.True(actual);
        }
        [Fact]
        public void CorrectPlayerSymbol_o()
        {
            Validation validate = new Validation();
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
        public void CheckForOcupiedPosition()
        {
            Board board = new Board(3);
            Validation validate = new Validation();
            board.GameBoard[0] = 'x';
            bool actual = validate.CheckPosition(board.GameBoard, 0);
            Assert.False(actual);
        }
        [Fact]
        public void CheckForEmptyPosition()
        {
            Board board = new Board(3);
            Validation validate = new Validation();
            bool actual = validate.CheckPosition(board.GameBoard, 0);
            Assert.True(actual);
        }
        [Fact]
        public void CheckForMultipleEmptyPosition()
        {
            Board board = new Board(3);
            Validation validate = new Validation();
            board.GameBoard[0] = 'x';
            board.GameBoard[1] = 'x';
            bool actual = validate.CheckPosition(board.GameBoard, 2);
            Assert.True(actual);
        }
        [Fact]
        public void CheckPositionOutOfRange()
        {
            Board board = new Board(3);
            Validation validate = new Validation();
            board.GameBoard[0] = 'x';
            board.GameBoard[1] = 'x';
            bool actual = validate.CheckPosition(board.GameBoard, 10);
            Assert.False(actual);
        }
        [Fact]
        public void CheckPositionLessThanRange()
        {
            Board board = new Board(3);
            Validation validate = new Validation();
            board.GameBoard[0] = 'x';
            board.GameBoard[1] = 'x';
            bool actual = validate.CheckPosition(board.GameBoard, -1);
            Assert.False(actual);
        }
    }
}
