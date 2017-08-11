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
using TanksGame.UI;

namespace TanksGame.Core
{
    public class Engine : IEngine
    {
        private static readonly IEngine instance = new Engine();

        private readonly IEnemiesProvider enemies;
        private readonly ITerrainProvider terrain;
        private readonly ITerrainGenerator terrainGenerator;
        private readonly IMover mover;
        
        private readonly IProjectileFactory projectileFactory;
        private readonly ITank firstPlayer;
        private readonly ITank secondPlayer;
        private readonly IDrawer drawer;

        private Engine()
        {
            this.enemies = EnemiesProvider.Instance;
            this.terrain = TerrainProvider.Instance;

            this.terrainGenerator = TerrainGenerator.Instance;

            this.drawer = new ConsoleDrawer();
            this.projectileFactory = new ProjectileFactory();

            this.terrain.Terrain = terrainGenerator.GenerateRandomMap(Constants.TerrainCountOnMap).ToList();
            this.mover = Mover.Instance;

            this.firstPlayer = this.terrainGenerator.GenerateFirstPlayer();
            this.secondPlayer = this.terrainGenerator.GenerateSecondPlayer();
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

                MoveProjectile(firstPlayer);
                MoveProjectile(secondPlayer);


                this.drawer.Draw(this.firstPlayer);
                this.drawer.Draw(this.secondPlayer);
                this.drawer.Draw(this.terrain.Terrain);
                this.drawer.Draw(this.firstPlayer.FiredProjectiles);
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
                    this.mover.MoveTank(this.firstPlayer, Direction.Top);
                    break;

                case ConsoleKey.A:
                    this.mover.MoveTank(this.firstPlayer, Direction.Left);
                    break;

                case ConsoleKey.S:
                    this.mover.MoveTank(this.firstPlayer, Direction.Down);
                    break;

                case ConsoleKey.D:
                    this.mover.MoveTank(this.firstPlayer, Direction.Right);
                    break;

                case ConsoleKey.Spacebar:
                    Tank.ShootSound();
                    IProjectile firstPlayerProjectile = this.projectileFactory.CreateProjectile(this.firstPlayer.WeaponType, this.firstPlayer.X + Constants.PlayerWidth / 2, this.firstPlayer.Y, Direction.Top);
                    this.firstPlayer.FiredProjectiles.Add(firstPlayerProjectile);
                    break;

                case ConsoleKey.D1:
                    Tank.Report();
                    break;

                //Second player controls !
                case ConsoleKey.UpArrow:
                    this.mover.MoveTank(this.secondPlayer, Direction.Top);
                    break;

                case ConsoleKey.LeftArrow:
                    this.mover.MoveTank(this.secondPlayer, Direction.Left);
                    break;

                case ConsoleKey.DownArrow:
                    this.mover.MoveTank(this.secondPlayer, Direction.Down);
                    break;

                case ConsoleKey.RightArrow:
                    this.mover.MoveTank(this.secondPlayer, Direction.Right);
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
                if (this.mover.MoveTank(p, p.Direction))
                {
                    tank.FiredProjectiles.Remove(p);
                }
            });
        }
    }
}