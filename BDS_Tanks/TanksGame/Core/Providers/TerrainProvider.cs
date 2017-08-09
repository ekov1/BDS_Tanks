using System.Collections.Generic;
using TanksGame.Core.Contracts;
using TanksGame.Environment.Terrains;

namespace TanksGame.Core.Providers
{
    public class TerrainProvider : ITerrainProvider
    {
        private static readonly TerrainProvider instance = new TerrainProvider();

        private TerrainProvider()
        {
            this.Terrain = new List<Terrain>();
        }

        public static TerrainProvider Instance
        {
            get
            {
                return instance;
            }
        }

        public ICollection<Terrain> Terrain { get; set; }
    }
}