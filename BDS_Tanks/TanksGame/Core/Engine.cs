using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Core.Factories;
using TanksGame.Core.Providers;
using TanksGame.Environment;
using TanksGame.Environment.Terrains;
using TanksGame.Player;
using TanksGame.UI;

namespace TanksGame.Core
{
    public class Engine : IEngine
    {
        private static readonly IEngine instance = new Engine();
        
        private readonly IEnemiesProvider enemies;
        private readonly ITerrainProvider terrain;
        private readonly IBoolTemplateProvider boolTemplateProvider;

        private readonly ITankFactory tankFactory;
        private readonly ITank player;
        private readonly IDrawer drawer;

        private Engine()
        {
            this.enemies = EnemiesProvider.Instance;
            this.terrain = TerrainProvider.Instance;
            this.boolTemplateProvider = BoolTemplateProvider.Instace;
            
            this.drawer = new ConsoleDrawer();
            this.tankFactory = new TankFactory();

            Texture playerBody = new Texture(this.boolTemplateProvider.GetBoolTemplate("tank"), '█', ConsoleColor.Green);
            this. player = tankFactory.CreateTank(10,10,playerBody,null);
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
            //Border border = new Border();
            Water water = new Water(30, 30);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey keyInfo = Console.ReadKey(true).Key;
                    switch (keyInfo)
                    {
                        case ConsoleKey.W:
                            this.player.Move(0, -Constants.PlayerHeight);
                            break;

                        case ConsoleKey.A:
                            this.player.Move(-Constants.PlayerHeight, 0);
                            break;

                        case ConsoleKey.S:
                            this.player.Move(0, Constants.PlayerHeight);
                            break;

                        case ConsoleKey.D:
                            this.player.Move(Constants.PlayerHeight, 0);
                            break;
                    }
                }
                
                drawer.Draw(this.player);
                drawer.Draw(water);

                Thread.Sleep(Constants.ThreadSleep);
                Console.Clear();
            }
        }
    }
}
