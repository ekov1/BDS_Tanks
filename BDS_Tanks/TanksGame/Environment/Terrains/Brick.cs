using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Providers;

namespace TanksGame.Environment.Terrains
{
    public abstract class Brick : Terrain
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
