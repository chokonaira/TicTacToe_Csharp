    using System;

    namespace TicTacToe.ConsoleGame
    {
        public class GameConsole
        {
            public static void Main(string[] args)
            {
                while (true)
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

                    //Player currentPlayer = player;
                    //display welcome message
                    output.DisplayString(message.WelcomeMassage);
                    //display game board
                    output.DisplayArray(board.GameBoard);
                    //display Game Instruction
                    output.DisplayString(message.GameInstruction);

                    output.DisplayString($"Its Player {player.Symbol}'s Turn.");

                    board.GetAvailableMoves();

                    while (!board.CheckDraw())
                    {
                        string input = Console.ReadLine();

                        if (validate.CheckString(input))
                        {
                            //Set Red Message Color
                            Console.ForegroundColor = ConsoleColor.Red;
                            output.DisplayString(validate.Message);
                            //Reset colour back to default
                            Console.ResetColor();
                            output.DisplayArray(board.GameBoard);
                            continue;
                        }
                        int position = Int32.Parse(input);

                        validate.CheckDigitRange(position);

                        if (!validate.CheckBoardRange(board.GameBoard, position))
                        {
                            //Set Red Message Color
                            Console.ForegroundColor = ConsoleColor.Red;
                            output.DisplayString(validate.Message);
                            //Reset colour back to default
                            Console.ResetColor();
                            output.DisplayArray(board.GameBoard);
                            continue;
                        }
                        if (!validate.CheckFreePosition(board.GameBoard, position))
                        {
                            //Set Red Message Color
                            Console.ForegroundColor = ConsoleColor.Red;
                            output.DisplayString(validate.Message);
                            //Reset colour back to default
                            Console.ResetColor();
                            output.DisplayArray(board.GameBoard);
                            continue;
                        }
                        board.MakeMove(player.Symbol, position);

                        output.DisplayArray(board.GameBoard);

                        if (board.CheckWin())
                        {
                            //Set Red Message Color
                            Console.ForegroundColor = ConsoleColor.Green;
                            output.DisplayString(message.SetWinMessage(player.Symbol));
                            //Set Red Message Color
                            Console.ResetColor();
                            break;
                        }
                        player.TogglePlayer();
                        output.DisplayString(message.ToggleMessage(player.Symbol));
                    }
                        output.DisplayString(message.StartAgain);

                        string answer = Console.ReadLine();
                        if (board.PlayAgain(answer))
                        {
                            continue;
                        }
                        return;
                }
            }
        }
    }
//