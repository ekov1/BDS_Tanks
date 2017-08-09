using TanksGame.Core.Enums;
using TanksGame.Environment.Terrains;

namespace TanksGame.Contracts
{
    public interface ITerrainFactory
    {
        Terrain CreateTerrain(TerrainType type, int x, int y);
    }
}