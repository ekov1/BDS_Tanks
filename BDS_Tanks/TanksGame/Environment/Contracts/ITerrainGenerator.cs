using System.Collections.Generic;
using TanksGame.Environment.Terrains;

namespace TanksGame.Environment.Contracts
{
    public interface ITerrainGenerator
    {
        IEnumerable<Terrain> GenerateRandomMap(int terrainElementsCount);
    }
}