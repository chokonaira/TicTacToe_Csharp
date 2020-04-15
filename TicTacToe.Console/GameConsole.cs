using System;

namespace TicTacToe.ConsoleGame
{
    public class GameConsole
    {
        public static void Main(string[] args)
        {
            //create message instance
            Message message = new Message();
            //create board instance
            Board board = new Board(3);
            //create validation instance
            Validation validate = new Validation();
            //create first player instance with a symbol
            Player player = new Player('x');
            //Player playerTwo = new Player('o');
            //create console interface
            IConsole console = new ConsoleWrapper();
            Output output = new Output(console);


            //display welcome message
            output.DisplayString(message.WelcomeMassage);
            //display game board
            output.DisplayArray(board.GameBoard);
            //display Game Instruction
            output.DisplayString(message.GameInstruction);

            board.GetAvailableMoves();

            while (!board.CheckDraw('x', 'o'))
            {
                int position = Convert.ToInt32(Console.ReadLine());

                if (!validate.CheckPosition(board.GameBoard, position))
                {
                    output.DisplayString(validate.ErrorMessage);

                    continue;
                }
                board.MakeMove(player.Symbol, position);

                output.DisplayArray(board.GameBoard);

                if (board.CheckWin(player.Symbol))
                {
                    //message.Winner = player.Symbol;
                    output.DisplayString(message.SetWinMessage(player.Symbol));
                    break;
                }
                player.TogglePlayer();
            }
           






            //get available moves on the board

            //get the board input

            //validate input

            //make move on position 1

            //display game board

            //get available moves on the board
            //------ board.GetAvailableMoves();
            //get the board input
            //------ int inputO = Convert.ToInt32(Console.ReadLine());
            //validate input
            //------ validate.CheckPosition(board.GameBoard, inputO);
            //board.GetAvailableMoves();------
            //make move on position 2
            //board.MakeMove(playerTwo, 1);
            //output.DisplayArray(board.GameBoard);
            ////output.DisplayBool(board.CheckWin('x'));

            //board.MakeMove('x', 1);
            //output.DisplayArray(board.GameBoard);
            ////output.DisplayBool(board.CheckWin('x'));

            //board.MakeMove('x', 2);
            //output.DisplayArray(board.GameBoard);
            ////output.DisplayBool(board.CheckWin('x'));

            //board.MakeMove('o', 3);
            //output.DisplayArray(board.GameBoard);
            ////output.DisplayBool(board.CheckWin('x'));

            //board.MakeMove('x', 4);
            //output.DisplayArray(board.GameBoard);
            ////output.DisplayBool(board.CheckWin('x'));

            //board.MakeMove('x', 5);
            //output.DisplayArray(board.GameBoard);

            //board.MakeMove('x', 6);
            //output.DisplayArray(board.GameBoard);

            //board.MakeMove('x', 7);
            //output.DisplayArray(board.GameBoard);

            //board.MakeMove('x', 8);
            //output.DisplayArray(board.GameBoard);

            //Console.WriteLine(message);
            //Console.WriteLine(board.GetBoard());
            //Console.WriteLine(instruction);
        }

        
    }
}
