using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;
using TanksGame.Environment.Terrains;

namespace TanksGame.Factories
{
    public class TerrainFactory : ITerrainFactory
    {
        private static TerrainFactory instance = new TerrainFactory();

        private TerrainFactory() { }

        public static TerrainFactory Instance
        {
            get
            {
                return instance;
            }
        }

        
        public Terrain GetTerrain()
        {
            throw new NotImplementedException();
        }
    }
}
