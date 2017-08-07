using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;
using TanksGame.Enums;
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
