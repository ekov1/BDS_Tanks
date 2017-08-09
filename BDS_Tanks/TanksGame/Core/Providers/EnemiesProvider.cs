using System.Collections.Generic;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;

namespace TanksGame.Core.Providers
{
    public class EnemiesProvider : IEnemiesProvider
    {
        // TODO: populate the enemies somehow 

        private static readonly EnemiesProvider instance = new EnemiesProvider();
        //private readonly ITankFactory tankFactory;  ?

        private EnemiesProvider()
        {
            this.EnemyTanks = new List<ITank>();
        }
        
        public static EnemiesProvider Instance
        {
            get
            {
                return instance;
            }
        }

        public ICollection<ITank> EnemyTanks { get; private set; }
    }
}