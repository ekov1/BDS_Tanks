using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Providers;

namespace TanksGame.Environment.Terrains
{
    public class Brick : Terrain
    {
        public Brick(int startX, int startY)
            : base(startX, startY,
                  new Texture(BoolTemplateProvider.Instace.GetBoolTemplate("terrain"), '▓', ConsoleColor.Red),
                  false, true)
        {

        }
    }
}
