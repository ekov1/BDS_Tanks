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
            : base(startX, startY,
                  new Texture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '░', ConsoleColor.Cyan),
                  true, false)
        {

        }
    }
}
