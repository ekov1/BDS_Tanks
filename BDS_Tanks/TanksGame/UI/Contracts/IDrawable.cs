using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Environment;

namespace TanksGame.UI
{
    public interface IDrawable
    {
        UnitBody UnitBody { get; set; }
        int X { get; set; }
        int Y { get; set; }
    }
}
