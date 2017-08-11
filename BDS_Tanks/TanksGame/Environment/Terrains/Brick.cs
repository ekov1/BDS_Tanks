using TanksGame.Core.Contracts;
using TanksGame.UI.Contracts;

namespace TanksGame.Environment.Terrains
{
    public abstract class Brick : Terrain, ITerrain, IDrawable, IPosition
    {
        private int health;
        private bool isDestroyed;

        public Brick(int startX, int startY)
            : base(startX, startY)
        {
            
        }
       
        public override bool IsPassable
        {
            get
            {
                return false;
            }
        }
        public override bool IsDestructable
        {
            get
            {
                return true;
            }
        }

        public void DecreaseHealth()
        {

        }
    }
}