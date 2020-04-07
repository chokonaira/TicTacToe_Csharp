using System;

namespace TicTacToe
{
    public class Board
    {
        public string EmptyBoard { get; }
        public char[] positions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public Board()
        {
            EmptyBoard = "     |     |     \n" +
                        "  {0}  |  {1}  |  {2}\n" +
                        "_____|_____|_____\n" +
                        "     |     |     \n" +
                        "  {3}  |  {4}  |  {5}\n" +
                        "_____|_____|_____\n" +
                        "     |     |     \n" +
                        "  {6}  |  {7}  |  {8}\n" +
                        "     |     |     \n";
        }

        public void SetPositions(int num, char value)
        {
            positions[num - 1] = value;
    }

        public string GetBoard()
        {
            return String.Format(EmptyBoard,
                 positions[0],
                 positions[1],
                 positions[2],
                 positions[3],
                 positions[4],
                 positions[5],
                 positions[6],
                 positions[7],
                 positions[8]);
        }

    }
}
