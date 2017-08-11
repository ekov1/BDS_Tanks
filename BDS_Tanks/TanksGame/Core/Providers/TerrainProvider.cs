using System.Collections.Generic;
using TanksGame.Core.Contracts;

namespace TanksGame.Core.Providers
{
    public class TerrainProvider : ITerrainProvider
    {
        private static readonly TerrainProvider instance = new TerrainProvider();

        private TerrainProvider()
        {
            this.Terrain = new List<ITerrain>();
        }

        public static TerrainProvider Instance
        {
            get
            {
                return instance;
            }
        }

        public ICollection<ITerrain> Terrain { get; set; }
    }
}