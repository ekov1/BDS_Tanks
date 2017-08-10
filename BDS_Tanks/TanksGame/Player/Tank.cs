using System;
using System.Collections.Generic;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Environment;
using TanksGame.Projectiles;
using TanksGame.UI.Contracts;

namespace TanksGame.Player
{
    public class Tank : ITank, IMovable, IDrawable
    {
        private string name;
        public Tank(int x, int y, Texture texture)
        {
            this.X = x;
            this.Y = y;
            this.Texture = texture;
            this.WeaponType = ProjectileType.MachineGun;
            this.FiredProjectiles = new List<IProjectile>();
        }
        
        public Texture Texture { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public ProjectileType WeaponType { get; set; }

        public ICollection<IProjectile> FiredProjectiles { get; protected set; }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public bool DefenseMode
        {
            get
            {
                throw new NotImplementedException();
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