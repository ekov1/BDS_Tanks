﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame.Environment
{
    public class UnitBody
    {
        public UnitBody(bool[,] body, char symbol, ConsoleColor color)
        {
            this.Body = body;
            this.Fill = symbol;
            this.Color = color;
        }

        public bool[,] Body { get; set; }
        public char Fill { get; set; }
        public ConsoleColor Color { get; set; }
    }
}
