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

        public Projectile(int x, int y, int damage)
        {
            this.Damage = damage;
            this.Direction = Direction.Top;

        }

        public abstract Texture Texture { get;  }
        public Direction Direction { get; set; }
        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Damage cannot be less than 1");
                }
                this.damage = value;
            }
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}