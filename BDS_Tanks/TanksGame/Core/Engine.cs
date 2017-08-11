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
using TanksGame.Player;
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
        private readonly IProjectileFactory projectileFactory;
        private readonly ITank player;
        private readonly ITank secondPlayer;
        private readonly IDrawer drawer;

        private Engine()
        {
            this.enemies = EnemiesProvider.Instance;
            this.terrain = TerrainProvider.Instance;
            this.boolTemplateProvider = BoolTemplateProvider.Instace;
            this.terrainGenerator = TerrainGenerator.Instance;

            this.drawer = new ConsoleDrawer();
            this.tankFactory = new TankFactory();
            this.projectileFactory = new ProjectileFactory();

            this.terrain.Terrain = terrainGenerator.GenerateRandomMap(Constants.TerrainCountOnMap).ToList();
            this.mover = Mover.Instance;


            FigureTexture playerBody = new FigureTexture(this.boolTemplateProvider.GetBoolTemplate("tank"), '█', ConsoleColor.Green);
            // TODO: generate oly for 2 player mode
            FigureTexture secondPlayerBody = new FigureTexture(this.boolTemplateProvider.GetBoolTemplate("secondTank"), '█', ConsoleColor.Magenta);

            // First Player !
            this.player = tankFactory.CreateTank(Constants.PlayerStartX, Constants.PlayerStartY,
                playerBody);
            // Second Player !
            this.secondPlayer = tankFactory.CreateTank(Constants.SecondPlayerStartX, Constants.SecondPlayerStartY,
                secondPlayerBody);


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

                    Controls(keyInfo);
                }

                MoveProjectile(player);
                MoveProjectile(secondPlayer);


                this.drawer.Draw(this.player);
                this.drawer.Draw(this.secondPlayer);
                this.drawer.Draw(this.terrain.Terrain);
                this.drawer.Draw(this.player.FiredProjectiles);
               this.drawer.Draw(this.secondPlayer.FiredProjectiles);

                Thread.Sleep(Constants.ThreadSleep);
                Console.Clear();
            }
        }
        public void Controls(ConsoleKey keyInfo)
        {
            switch (keyInfo)
            {
                //First player controls !
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

                case ConsoleKey.Spacebar:
                    Tank.ShootSound();
                    IProjectile firstPlayerProjectile = this.projectileFactory.CreateProjectile(this.player.WeaponType, this.player.X + Constants.PlayerWidth / 2, this.player.Y, Direction.Top);
                    this.player.FiredProjectiles.Add(firstPlayerProjectile);
                    break;

                case ConsoleKey.D1:
                    Tank.Report();
                    break;

                //Second player controls !
                case ConsoleKey.UpArrow:
                    this.mover.Move(this.secondPlayer, Direction.Top);
                    break;

                case ConsoleKey.LeftArrow:
                    this.mover.Move(this.secondPlayer, Direction.Left);
                    break;

                case ConsoleKey.DownArrow:
                    this.mover.Move(this.secondPlayer, Direction.Down);
                    break;

                case ConsoleKey.RightArrow:
                    this.mover.Move(this.secondPlayer, Direction.Right);
                    break;

                case ConsoleKey.Enter:
                    IProjectile secondPlayerProjectile = this.projectileFactory.CreateProjectile(this.secondPlayer.WeaponType, this.secondPlayer.X + Constants.PlayerWidth / 2, this.secondPlayer.Y, Direction.Down);
                    this.secondPlayer.FiredProjectiles.Add(secondPlayerProjectile);
                    Tank.ShootSound();
                    break;

                case ConsoleKey.NumPad0:
                    Tank.Report();
                    break;
            }
        }
        public void MoveProjectile(ITank tank)
        {
             tank.FiredProjectiles.ToList().ForEach(p =>
            {
                if (this.mover.Move(p, p.Direction))
                {
                    tank.FiredProjectiles.Remove(p);
                }
            });
        }
    }
}