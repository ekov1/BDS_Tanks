using System.Collections.Generic;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;

namespace TanksGame.Environment.Contracts
{
    public interface ITerrainGenerator
    {
        IEnumerable<ITerrain> GenerateRandomMap(int terrainElementsCount);

        ITank GenerateFirstPlayer();

        ITank GenerateSecondPlayer();
    }
}