using System.Collections.Generic;
using TanksGame.Contracts;

namespace TanksGame.Core.Contracts
{
    public interface IEnemiesProvider
    {
        ICollection<ITank> EnemyTanks { get; }
    }
}