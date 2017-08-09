using TanksGame.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Environment;

namespace TanksGame.Projectiles
{
    public abstract class Projectile : IProjectile
    {
        private Direction direction;
        private Texture body; // interface ?
        private int speed;
        private int damage;
        private bool canBreakWall;
    }
}