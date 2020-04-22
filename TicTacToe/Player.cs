    using System;
    namespace TicTacToe
    {
        public class Player
        {
            public char Symbol { get; set; }


            public Player(char symbol)
            {
                Symbol = symbol;
            }
            public void TogglePlayer()
            {
                Symbol = Symbol == 'X' ? 'O' : 'X';
            }

           
        }
    }
