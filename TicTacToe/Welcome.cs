﻿using System;

namespace TicTacToe
{
    public class Welcome
    {
        public string _welcomeMassage { get; set; }


        public string WelcomeMassage()
        {
            _welcomeMassage = "Welcome to Tic Tac Toe!";
            return _welcomeMassage;
        }
    }
    
}
