using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.UI;

namespace TanksGame.Contracts
{
    public interface ITank : IMovable, IDrawable
    {
         void Attack();
    }
}
