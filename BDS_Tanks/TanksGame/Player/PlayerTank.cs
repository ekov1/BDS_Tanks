using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;
using TanksGame.Environment;

namespace TanksGame.Player
{
    class PlayerTank : Tank
    {
        public PlayerTank(int x, int y, UnitBody unitBody, IProjectile weapon) 
            : base(x, y, unitBody, weapon)
        {
        }
    }
}
