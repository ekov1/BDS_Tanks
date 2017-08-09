﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Environment;
using TanksGame.Projectiles;
using TanksGame.UI;

namespace TanksGame.Player
{
    public class Tank : ITank
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

        public int X { get; set; }

        public int Y { get; set; }

        public Texture Texture { get; set; }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Move(int offsetX, int offsetY)
        {


            if (this.X + offsetX > 0 && this.X + offsetX <= Constants.ConsoleWidth - Constants.PlayerWidth)
            {
                this.X += offsetX;
            }

            if (this.Y + offsetY > 0 && this.Y + offsetY <= Constants.ConsoleHeight - Constants.PlayerHeight)
            {
                this.Y += offsetY;
            }
        }
    }
}
