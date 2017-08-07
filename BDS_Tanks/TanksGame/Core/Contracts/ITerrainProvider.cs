using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Environment.Terrains;

namespace TanksGame.Core.Contracts
{
    public interface ITerrainProvider
    {
        ICollection<Terrain> Terrain { get; }
    }
}
