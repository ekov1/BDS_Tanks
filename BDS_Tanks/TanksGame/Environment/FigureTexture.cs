using System;
using System.Collections.Generic;
using TanksGame.Environment.Contracts;

namespace TanksGame.Environment
{
    public class FigureTexture : Texture, ITexture, IFigureTexture
    {
        
        public FigureTexture(ICollection<IEnumerable<bool>> body, char symbol, ConsoleColor color) : base(body)
        {
            this.Symbol = symbol;
            this.Color = color;
        }

        public char Symbol { get ; set; }
        public ConsoleColor Color { get; set ; }
    }
}