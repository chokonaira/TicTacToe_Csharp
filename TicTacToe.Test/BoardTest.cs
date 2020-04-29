    using System;
using System.Collections.Generic;
using Xunit;

    namespace TicTacToe.Test
    {
        internal static class Helper
        {
            public static void FillBoard(Board board, int[] positions, char[] symbols)
            {
                for (int i = 0; i < positions.Length; i++)
                {
                    board.MakeMove(symbols[i], positions[i]);
                }
            }
        }

        //internal static class HelperList
        //{
        //    public static void FillBoard(Board board, List<int> positions, List<char> symbols)
        //    {
        //        for (int i = 0; i < positions.Length; i++)
        //        {
        //            board.MakeMove(symbols[i], positions[i]);
        //        }
        //    }
        //}


        public class BoardTest
        {
        
            [Fact]
            public void SpecifyGameBoardSIze()
            {
                var board = new Board(3);
                int actual = board.GameBoard.Length;
                Assert.Equal(9, actual);
            }

            [Fact]
            public void CheckForMoveOnBoardX()
            {
                var board = new Board(3);
                board.MakeMove('X',1);
                char expected = 'X';
                Assert.Equal(expected, board.GameBoard[0]);
            }

            [Fact]
            public void CheckForMoveOnBoardO()
            {
                var board = new Board(3);
                board.MakeMove('O', 1);
                char expected = 'O';
                Assert.Equal(expected, board.GameBoard[0]);
            }

            [Fact]
            public void CheckForAvailableMoves()
            {
                var board = new Board(3);
                int expected = 9;
                Assert.Equal(expected, board.GetAvailableMoves());
            }

            [Fact]
            public void CheckBoardForValidMove()
            {
                var board = new Board(3);
                board.MakeMove('O', 1);
                int expected = 8;
                Assert.Equal(expected, board.GetAvailableMoves());
            }

            [Fact]
            public void CheckBoardForHorizontalWin()
            {
                var board = new Board(3);
                int[] positions = { 1, 5, 9 };
                char[] symbols = { 'X', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                char actual = board.WinningPlayer();
                Assert.Equal('X', actual);

            }

            [Fact]
            public void CheckBoardForVerticalWin()
            {
                var board = new Board(3);
                int[] positions = { 1, 4, 7 };
                char[] symbols = { 'O', 'O', 'O' };
                Helper.FillBoard(board, positions, symbols);
                char actual = board.WinningPlayer();
                Assert.Equal('O', actual);
            }

            [Fact]
            public void CheckBoardForDiagonalWin()
            {
                var board = new Board(3);
                int[] positions = { 3, 5, 7 };
                char[] symbols = { 'X', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                char actual = board.WinningPlayer();
                Assert.Equal('X', actual);

            }

            [Fact]
            public void CheckBoardForSecondDiagonalWin()
            {
                var board = new Board(3);
                int[] positions = { 1, 5, 9 };
                char[] symbols = { 'X','X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                char actual = board.WinningPlayer();
                Assert.Equal('X', actual);
            }

            [Fact]
            public void CheckForActualDraw()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                char[] symbols = { 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                bool actual = board.CheckDraw();

                Assert.Equal("Its a Draw!", board.DrawMessage);
                Assert.True(actual);
            }

            [Fact]
            public void FalseDrawIfWin()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                char[] symbols = { 'X', 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                var actual = board.CheckDraw();
                Assert.False(actual);
            }
            [Fact]
            public void FalseDrawIfBoardHasAvailableMoves()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8 };
                char[] symbols = { 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                var actual = board.CheckDraw();
                Assert.False(actual);
            }

            [Fact]
            public void ClearGameBoard()
            {
                var board = new Board(3);
                //Arrange
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                char[] symbols = { 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);

                Assert.Equal(0, board.GetAvailableMoves());

                board.InitializeBoard();
                Assert.Equal(9, board.GetAvailableMoves());
            
                char[] expected = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                //Act
                var actual = board.GameBoard;
                //Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void YesPlayAgainWhenWin()
            {
                var board = new Board(3);
                int[] positions = { 3, 5, 7 };
                char[] symbols = { 'X', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);

                char actual = board.WinningPlayer();
                Assert.Equal('X', actual);
                bool expected = board.PlayAgain("y");
                Assert.True(expected);
            }
            [Fact]
            public void YesPlayAgainWhenDraw()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                char[] symbols = { 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                bool actual = board.CheckDraw();

                Assert.Equal("Its a Draw!", board.DrawMessage);
                Assert.True(actual);

                bool expected = board.PlayAgain("y");
                Assert.True(expected);
            }
            [Fact]
            public void NoPlayAgainWhenWin()
            {
                var board = new Board(3);
                int[] positions = { 3, 5, 7 };
                char[] symbols = { 'X', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);

                char actual = board.WinningPlayer();
                Assert.Equal('X', actual);
                bool expected = board.PlayAgain("uuu");
                Assert.False(expected);
            }
            [Fact]
            public void NoPlayAgainWhenDraw()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                char[] symbols = { 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                bool actual = board.CheckDraw();

                Assert.Equal("Its a Draw!", board.DrawMessage);
                Assert.True(actual);

                bool expected = board.PlayAgain("ghge");
                Assert.False(expected);
            }
            [Fact]
            public void CheckGameOverIfWin()
            {
                var board = new Board(3);
                int[] positions = { 1, 5, 9 };
                char[] symbols = { 'X', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                bool actual = board.IsGameOver();
                Assert.True(actual);
            }
            [Fact]
            public void CheckGameOverIfDraw()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                char[] symbols = { 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'X', 'X' };
                Helper.FillBoard(board, positions, symbols);
                bool actual = board.IsGameOver();
                Assert.True(actual);
            }
            [Fact]
            public void CheckForAllEmptyMovePositionsOnBoard()
            {
                var board = new Board(3);
                List<int> actual = board.GetMovePositions();
                int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Assert.Equal(expected, actual);
            }
            [Fact]
            public void CheckFor_5_EmptyMovePositionsOnBoard()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4 };
                char[] symbols = { 'X', 'O', 'X', 'O' };
                Helper.FillBoard(board, positions, symbols);
                List<int> actual = board.GetMovePositions();
                int[] expected = { 5, 6, 7, 8, 9 };
                Assert.Equal(expected, actual);
            }
            [Fact]
            public void CheckFor_7_EmptyPositionOnBoard()
            {
                var board = new Board(3);
                int[] positions = { 3, 4 };
                char[] symbols = { 'X', 'O' };
                Helper.FillBoard(board, positions, symbols);
                List<int> actual = board.GetMovePositions();
                int[] expected = { 1, 2, 5, 6, 7, 8, 9 };
                Assert.Equal(expected, actual);
            }
            [Fact]
            public void CheckFor_0_EmptyPositionOnBoard()
            {
                var board = new Board(3);
                int[] positions = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                char[] symbols = { 'X', 'O', 'X', 'O', 'X', 'O', 'X', 'O', 'X' };
                Helper.FillBoard(board, positions, symbols);
                List<int> actual = board.GetMovePositions();
                int[] expected = { };
                Assert.Equal(expected, actual);
            }
        }
    }

