using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Environment.Terrains;

namespace TanksGame.Core.Factories
{
    public class TerrainFactory : ITerrainFactory
    {
        public Terrain CreateTerrain(TerrainType type, int x, int y)
        {
            switch (type)
            {
                case TerrainType.Brick:
                    return new Brick(x, y);
                case TerrainType.Stone:
                    return new Stone(x, y);
                case TerrainType.Water:
                    return new Water(x, y);
                default:
                    // create stone by default
                    return new Stone(x, y);
            }
        }
    }
}
