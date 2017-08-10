using System;
using TanksGame.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;
using TanksGame.UI;
using TanksGame.UI.Contracts;

namespace TanksGame.Projectiles
{
    public abstract class Projectile : IProjectile, IMovable, IDrawable
    {
        private int damage;

        public Projectile(int x, int y, Direction direction)
        {
            this.X = x;
            this.Y = y;
            this.Direction = direction;

        }
        
        public abstract IFigureTexture FigureTexture { get;  }

        public abstract int Damage { get; }
        public Direction Direction { get; set; }


        public int X { get; set; }
        public int Y { get; set; }
    }
}