using System;
using System.Collections.Generic;
using TanksGame.Core.Contracts;
using TanksGame.Player;

namespace TanksGame.Core.Providers
{
    public class EnemiesProvider : IEnemiesProvider
    {
        private static readonly EnemiesProvider instance = new EnemiesProvider();

        private EnemiesProvider()
        {
            this.EnemyTanks = new List<Tank>();
        }
        
        public static EnemiesProvider Instance
        {
            get
            {
                return instance;
            }
        }

        public ICollection<Tank> EnemyTanks { get; private set; }
    }
}
