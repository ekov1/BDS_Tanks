using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Player;

namespace TanksGame.Core.Contracts
{
    public interface ITankFactory
    {
        Tank CreateTank();
    }
}
