using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ICollection<Terrain> Terrain { get; private set; }
    }
}
