using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Environment.Terrains;

namespace TanksGame.Contracts
{
    public interface ITerrainFactory
    {
        Terrain CreateTerrain();
    }
}
