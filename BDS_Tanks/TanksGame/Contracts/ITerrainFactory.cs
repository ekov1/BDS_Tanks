using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;

namespace TanksGame.Contracts
{
    public interface ITerrainFactory
    {
        ITerrain CreateTerrain(TerrainType type, int x, int y);
    }
}