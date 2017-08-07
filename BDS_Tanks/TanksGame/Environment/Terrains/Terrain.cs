
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Contracts;

namespace TanksGame.Environment.Terrains
{
    public abstract class Terrain : ITerrain
    {
        public Terrain(int startX, int startY, Texture texture, bool isPassable, bool isDestructable)
        {
            this.X = startX;
            this.Y = startY;
            this.Texture = texture;
            this.IsPassable = isPassable;
            this.IsDestructable = isDestructable;
        }


        public int X { get; set; }

        public int Y { get;  set; }

        public Texture Texture { get; set; }

        public bool IsPassable { get; protected set; }

        public bool IsDestructable { get; protected set; }
    }
}
