using System;
using System.Linq;
using System.Threading;
using TanksGame.Common;
using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Core.Factories;
using TanksGame.Core.Providers;
using TanksGame.Environment;
using TanksGame.Environment.Contracts;
using TanksGame.Projectiles;
using TanksGame.UI;

namespace TanksGame.Core
{
    public class Engine : IEngine
    {
        private static readonly IEngine instance = new Engine();

        private readonly IEnemiesProvider enemies;
        private readonly ITerrainProvider terrain;
        private readonly IBoolTemplateProvider boolTemplateProvider;
        private readonly ITerrainGenerator terrainGenerator;
        private readonly IMover mover;

        private readonly ITankFactory tankFactory;
        private readonly ITank player;
        private readonly IDrawer drawer;

        private Engine()
        {
            this.enemies = EnemiesProvider.Instance;
            this.terrain = TerrainProvider.Instance;
            this.boolTemplateProvider = BoolTemplateProvider.Instace;
            this.terrainGenerator = TerrainGenerator.Instance;
            
            this.drawer = new ConsoleDrawer();
            this.tankFactory = new TankFactory();

            this.terrain.Terrain = terrainGenerator.GenerateRandomMap(Constants.TerrainCountOnMap).ToList();
            this.mover = Mover.Instance;

            Texture playerBody = new Texture(this.boolTemplateProvider.GetBoolTemplate("tank"), '█', ConsoleColor.Green);

            this.player = tankFactory.CreateTank(Constants.PlayerStartX, Constants.PlayerStartY, 
                playerBody, new MachineGun(Constants.PlayerStartX,Constants.PlayerStartY,Constants.MachineGunDamage));
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
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey keyInfo = Console.ReadKey(true).Key;
                    switch (keyInfo)
                    {
                        case ConsoleKey.W:
                            this.mover.Move(this.player, Direction.Top);
                            break;

                        case ConsoleKey.A:
                            this.mover.Move(this.player, Direction.Left);
                            break;

                        case ConsoleKey.S:
                            this.mover.Move(this.player, Direction.Down);
                            break;

                        case ConsoleKey.D:
                            this.mover.Move(this.player, Direction.Right);
                            break;
                    }
                }

                this.drawer.Draw(this.player);
                this.drawer.Draw(this.terrain.Terrain);
                this.drawer.Draw(this.player.Weapon);

                Thread.Sleep(Constants.ThreadSleep);
                Console.Clear();
            }
        }
    }
}