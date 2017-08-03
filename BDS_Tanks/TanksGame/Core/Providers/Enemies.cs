using System;
using System.Collections.Generic;
using TanksGame.Core.Contracts;

namespace TanksGame.Core.Providers
{
    public class Enemies : IEnemies
    {
        private static readonly Enemies instance = new Enemies();

        private Enemies()
        {
            this.EnemyTanks = new List<Tank>();
        }
        
        public static Enemies Instance
        {
            get
            {
                return instance;
            }
        }

        public ICollection<Tank> EnemyTanks { get; private set; }
    }
}
