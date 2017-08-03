using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Contracts;

namespace TanksGame
{
    public abstract class Tank
    {
        public Tank(int x, int y, IProjectile weapon)
        {
            this.Position.X = x;
            this.Position.Y = y;
            this.Weapon = weapon;
        }

        public Position Position { get; set; }

        // will determine the damage
        public IProjectile Weapon { get; set; }

    }
}
