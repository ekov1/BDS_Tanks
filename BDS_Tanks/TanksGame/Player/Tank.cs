using System;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Environment;
using TanksGame.Projectiles;
using TanksGame.UI.Contracts;

namespace TanksGame.Player
{
    public class Tank : ITank, IMovable, IDrawable
    {
        private string name;

        public Tank(int x, int y, Texture texture, IProjectile weapon)
        {
            this.X = x;
            this.Y = y;
            this.Texture = texture;
            this.Weapon = weapon;
        }

        // will determine the damage
    
        
        public Texture Texture { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IProjectile Weapon { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public void Attack()
        {
           
        }

        public void Report()
        {
           
        }
    }
}