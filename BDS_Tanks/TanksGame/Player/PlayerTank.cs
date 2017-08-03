using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;

namespace TanksGame.Player
{
    class PlayerTank : Tank, IMovable
    {
        public PlayerTank(int x, int y, IProjectile weapon) 
            : base(x, y, weapon)
        {
        }
    }
}
