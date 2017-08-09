using System.Collections.Generic;
using TanksGame.Environment.Terrains;

namespace TanksGame.Core.Contracts
{
    public interface ITerrainProvider
    {
        ICollection<Terrain> Terrain { get; set; }
    }
}