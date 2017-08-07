using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Environment.Terrains;

namespace TanksGame.Environment
{
    public static class TerrainGenerator
    {
        public static ICollection<IEnumerable<bool>> TankBody = new List<IEnumerable<bool>>{
            new bool[] { false, true, false }, new bool[]{ true, true, true }, new bool[]{ true, true, true } };
        
        public static IEnumerable<Terrain> GenerateRandomMap(int blocks)
        {
            var terrain = new List<Terrain>();

            for (int i = 0; i < blocks; i++)
            {

            }

            return terrain;

        }
    }
}
