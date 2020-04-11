using System;

namespace TicTacToe.ConsoleGame
{
    public class GameConsole
    {
        public static void Main(string[] args)
        {
            Welcome game = new Welcome();
            Board board = new Board(3);
            IConsole console = new ConsoleWrapper();
            Output output = new Output(console);
            string message = game.WelcomeMassage;
            string instruction = game.GameInstruction;


            output.DisplayString(message);
            output.DisplayArray(board.GameBoard);
            output.DisplayString(instruction);


            board.MakeMove('x', 0);
            output.DisplayArray(board.GameBoard);
            //output.DisplayBool(board.CheckWin('x'));

            board.MakeMove('x', 1);
            output.DisplayArray(board.GameBoard);
            //output.DisplayBool(board.CheckWin('x'));

            board.MakeMove('x', 2);
            output.DisplayArray(board.GameBoard);
            //output.DisplayBool(board.CheckWin('x'));

            board.MakeMove('o', 3);
            output.DisplayArray(board.GameBoard);
            //output.DisplayBool(board.CheckWin('x'));

            board.MakeMove('x', 4);
            output.DisplayArray(board.GameBoard);
            //output.DisplayBool(board.CheckWin('x'));

            board.MakeMove('x', 5);
            output.DisplayArray(board.GameBoard);

            board.MakeMove('x', 6);
            output.DisplayArray(board.GameBoard);

            board.MakeMove('x', 7);
            output.DisplayArray(board.GameBoard);

            board.MakeMove('x', 8);
            output.DisplayArray(board.GameBoard);
            //Console.WriteLine(message);
            //Console.WriteLine(board.GetBoard());
            //Console.WriteLine(instruction);
        }

        
    }
}
