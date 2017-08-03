using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Player;

namespace TanksGame.Core
{
    public class Engine : IEngine
    {
        private static readonly IEngine instance = new Engine();

        private readonly Tank player;
        private readonly IEnemies enemies;

        private Engine()
        {
            this.player = new PlayerTank(150, 150, null);
            this.enemies = Enemies.Instance;
        }


        public static IEngine Instance
        {
            get
            {
                return instance;
            }
        }

        public void Run()
        {

        }
    }
}
