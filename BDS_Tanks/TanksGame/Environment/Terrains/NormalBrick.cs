using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Enums;

namespace TanksGame.Environment.Terrains
{
    class NormalBrick : Brick
    {
        private int health;
        public NormalBrick(int startX, int startY)
            : base(startX, startY)
        {
            this.health = (int)HealthList.NormalBrickHealth;
        }
    }
}
