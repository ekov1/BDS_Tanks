using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanksGame.Environment.Terrains
{
    public class Water : Terrain
    {
        public Water(int startX, int startY)
            : base(startX, startY, null, true, false)
        {

        }
    }
}
