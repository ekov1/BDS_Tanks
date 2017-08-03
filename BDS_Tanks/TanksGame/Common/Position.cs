using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame.Common
{
    public class Position
    {
        private int x;
        private int y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Screen position X cannot be negative");
                }
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Screen position Y cannot be negative");
                }
                this.y = value;
            }
        }
    }
}
