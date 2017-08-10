using System;
using TanksGame.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Environment;
using TanksGame.UI;
using TanksGame.UI.Contracts;

namespace TanksGame.Projectiles
{
    public abstract class Projectile : IProjectile, IMovable, IDrawable
    {
        private int damage;

        public Projectile(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Direction = Direction.Top;

        }

        public abstract Texture Texture { get; }
        public abstract int Damage { get; }
        public Direction Direction { get; set; }


        public int X { get; set; }
        public int Y { get; set; }
    }
}