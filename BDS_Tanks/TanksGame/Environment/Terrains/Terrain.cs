using TanksGame.Core.Contracts;
using TanksGame.Environment.Contracts;
using TanksGame.UI.Contracts;

namespace TanksGame.Environment.Terrains
{
    public abstract class Terrain : ITerrain, IDrawable, IPosition
    {
        public Terrain(int startX, int startY)
        {
            this.X = startX;
            this.Y = startY;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public abstract IFigureTexture FigureTexture { get; }

        public abstract bool IsPassable { get; }

        public abstract bool IsDestructable { get; }
    }
}