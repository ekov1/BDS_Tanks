using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Enums;
using TanksGame.Core.Providers;

namespace TanksGame.Environment.Terrains
{
    class SteelBrick : Brick
    {
        private int health;

        public SteelBrick(int startX, int startY)
            : base(startX, startY)
        {
            this.health = (int)HealthList.SteelBrickHealth;
        }

        public override Texture Texture
        {
            get
            {
                return new Texture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '±', ConsoleColor.Red); ;
            }
        }
    }
}
