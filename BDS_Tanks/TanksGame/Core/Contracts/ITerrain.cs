using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Environment;
using TanksGame.UI;

namespace TanksGame.Core.Contracts
{
    public interface ITerrain : IDrawable
    {
        bool IsPassable { get; }

        bool IsDestructable { get; }
    }
}
