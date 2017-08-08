using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Environment;
using TanksGame.Player;

namespace TanksGame.Core.Factories
{
    public class TankFactory : ITankFactory
    {
        public ITank CreateTank(int x, int y, Texture texture, IProjectile weapon)
        {
            return new Tank(x, y, texture, weapon);
        }
    }
}
