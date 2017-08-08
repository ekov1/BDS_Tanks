using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;
using TanksGame.Environment;
using TanksGame.Player;

namespace TanksGame.Core.Contracts
{
    public interface ITankFactory
    {
        ITank CreateTank(int x, int y, Texture texture, IProjectile weapon);
    }
}
