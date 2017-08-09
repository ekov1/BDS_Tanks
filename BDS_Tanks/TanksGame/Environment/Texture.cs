using System;
using System.Collections.Generic;

namespace TanksGame.Environment
{
    public class Texture
    {
        public Texture(ICollection<IEnumerable<bool>> body, char symbol, ConsoleColor color)
        {
            this.Body = body;
            this.Symbol = symbol;
            this.Color = color;
        }

        public ICollection<IEnumerable<bool>> Body { get; set; }
        public char Symbol { get; set; }
        public ConsoleColor Color { get; set; }
    }
}