using System;
using TanksGame.Contracts;
using TanksGame.Environment;
using TanksGame.Projectiles;

namespace TanksGame.Player
{
    public class Tank : ITank, IMovable
    {
        public Tank(int x, int y, Texture texture, IProjectile weapon)
        {
            this.X = x;
            this.Y = y;
            this.Texture = texture;
            this.Weapon = new MachineGun();
        }

        // will determine the damage
        public IProjectile Weapon { get; set; }
        
        public Texture Texture { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}