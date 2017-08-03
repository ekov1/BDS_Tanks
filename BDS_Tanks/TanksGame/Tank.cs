using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Environment;
using TanksGame.Projectiles;
using TanksGame.UI;

namespace TanksGame
{
    public abstract class Tank : IMovable, IDrawable
    {
        public Tank(int x, int y, UnitBody unitBody,IProjectile weapon)
        {
            this.X = x;
            this.Y = y;
            this.UnitBody = unitBody;
            this.Weapon = new MachineGun();
        }

        // will determine the damage
        public IProjectile Weapon { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
        public UnitBody UnitBody { get; set; }

        public void Move(int offsetX, int offsetY)
        {
            this.X += offsetX;
            this.Y += offsetY;
        }
    }
}
