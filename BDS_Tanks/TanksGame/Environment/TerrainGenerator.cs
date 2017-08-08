using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Core.Factories;
using TanksGame.Environment.Contracts;
using TanksGame.Environment.Terrains;

namespace TanksGame.Environment
{
    public class TerrainGenerator : ITerrainGenerator
    {
        private static readonly TerrainGenerator instance = new TerrainGenerator();
        private ITerrainFactory terrainFactory;

        private TerrainGenerator()
        {
            this.terrainFactory = new TerrainFactory();
        }

        public static TerrainGenerator Instance
        {
            get
            {
                return instance;
            }
        }

        public IEnumerable<Terrain> GenerateRandomMap(int terrainElementsCount)
        {
            var terrainList = new List<Terrain>();
            Random randomGen = new Random();

            int enumLength = Enum.GetNames(typeof(TerrainType)).Length;

            for (int i = 0; i < terrainElementsCount; i++)
            {
                // TODO: How to decouple with Constants ? How to inject Random for testibility (Wrap in in interace?)
                int randomTerrain = randomGen.Next(0, enumLength);
                int randomX = randomGen.Next(0, Constants.ConsoleWidth - Constants.TerrainWidth);
                int randomY = randomGen.Next(0, Constants.ConsoleHeight - Constants.TerrainHeight);

                Terrain currTerrain = this.terrainFactory.CreateTerrain((TerrainType)randomTerrain,randomX, randomY);
                terrainList.Add(currTerrain);
            }

            return terrainList;

        }
    }
}
