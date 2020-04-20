using System;
namespace TicTacToe.ConsoleGame
{
    public class ConsoleWrapper : IConsole
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteArray(char[] array)
        {
            int x = 0;
            for(int i=0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"-|{array[x]}|-");
                    x++;
                }
                Console.WriteLine();
            }
        }
    }
}
