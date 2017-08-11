using System.Collections.Generic;

namespace TanksGame.Core.Contracts
{
    public interface ITerrainProvider
    {
        ICollection<ITerrain> Terrain { get; set; }
    }
}