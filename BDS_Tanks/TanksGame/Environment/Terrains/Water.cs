using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Providers;

namespace TanksGame.Environment.Terrains
{
    public class Water : Terrain
    {
        public Water(int startX, int startY)
            : base(startX, startY) { }

        public override Texture Texture
        {
            get
            {
                return new Texture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '░', ConsoleColor.Cyan);
            }
        }
        public override bool IsPassable
        {
            get
            {
                return true;
            }
        }
        public override bool IsDestructable
        {
            get
            {
                return false;
            }
        }
    }
}
