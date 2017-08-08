﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Contracts;
using TanksGame.Player;

namespace TanksGame.Core.Contracts
{
    public interface IEnemiesProvider
    {
        ICollection<ITank> EnemyTanks { get; }
    }
}