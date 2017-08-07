using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.UI;

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
