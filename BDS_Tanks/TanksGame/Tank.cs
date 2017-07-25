using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;

namespace TanksGame
{
    public abstract class Tank
    {
        // will determine the damage
        IProjectile weapon;

        public Tank(IProjectile weapon)
        {
            this.weapon = weapon;
        }

        // Change weapon
    }
}
