using System;
using System.Collections.Generic;
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
        private IField field;
        private ITerrainFactory terrainFactory;

        private TerrainGenerator()
        {
            this.terrainFactory = new TerrainFactory();
            this.field = Field.Instance;
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
                var flag = 1;
                Terrain currTerrain;
                do
                {
                    // TODO: How to decouple with Constants ? How to inject Random for testibility (Wrap it in interace? / i think so ( Mariyan ))
                    int randomTerrain = randomGen.Next(0, enumLength);
                    int randomX = randomGen.Next(0, Constants.ConsoleWidth - Constants.TerrainWidth);
                    int randomY = randomGen.Next(0, Constants.ConsoleHeight - Constants.TerrainHeight);

                    FillField(randomX, randomY);

                    currTerrain = this.terrainFactory.CreateTerrain((TerrainType)randomTerrain, randomX, randomY);

                    foreach (var item in terrainList)
                    {
                        if (currTerrain.X >= item.X && currTerrain.X <= item.X + 4 &&
                            currTerrain.Y >= item.Y && currTerrain.Y < item.Y + 4 &&
                            currTerrain.X + 4 >= item.X && currTerrain.X + 4 <= item.X + 4 &&
                            currTerrain.Y + 4 >= item.Y && currTerrain.Y + 4 < item.Y + 4)
                        {
                            flag = 0;
                            break;
                        }
                        else
                        {
                            //Console.WriteLine("aaaaaaa");
                            //Console.ReadLine();
                            flag = 1;
                        }
                    }
                } while (flag < 1);

                terrainList.Add(currTerrain);
            }

            return terrainList;
        }

        private void FillField(int x, int y)
        {
            this.field.OccupyField(x, y);
            this.field.OccupyField(x + 1, y);
            this.field.OccupyField(x + 2, y);
            this.field.OccupyField(x + 3, y);
         //   this.field.OccupyField(x + 4, y);

            this.field.OccupyField(x, y + 1);
            this.field.OccupyField(x + 1, y + 1);
            this.field.OccupyField(x + 2, y + 1);
            this.field.OccupyField(x + 3, y + 1);
          //  this.field.OccupyField(x + 4, y + 1);

            this.field.OccupyField(x, y + 2);
            this.field.OccupyField(x + 1, y + 2);
            this.field.OccupyField(x + 2, y + 2);
            this.field.OccupyField(x + 3, y + 2);
         //   this.field.OccupyField(x + 4, y + 2);
        }
    }
}