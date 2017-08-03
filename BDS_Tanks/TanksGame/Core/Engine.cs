using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TanksGame.Common;
using TanksGame.Core.Contracts;
using TanksGame.Core.Providers;
using TanksGame.Environment;
using TanksGame.Player;
using TanksGame.UI;

namespace TanksGame.Core
{
    public class Engine : IEngine
    {
        private static readonly IEngine instance = new Engine();

        private readonly Tank player;
        private readonly IEnemies enemies;
        private readonly IDrawer drawer;

        private Engine()
        {
            var playerBody = new UnitBody(new bool[,] { { false, true, false }, { true, true, true }, { true, true, true } }, '*', ConsoleColor.Green);
            this.player = new PlayerTank(10, 10, playerBody, null);
            this.enemies = Enemies.Instance;
            this.drawer = new ConsoleDrawer();
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
                drawer.Draw(this.player);

                if (Console.KeyAvailable)
                {
                    ConsoleKey keyInfo = Console.ReadKey(true).Key;
                    switch (keyInfo)
                    {
                        case ConsoleKey.W:
                            this.player.Move(0, -Constants.PlayerMovementSpeed);
                            break;

                        case ConsoleKey.A:
                            this.player.Move(-Constants.PlayerMovementSpeed, 0);
                            break;

                        case ConsoleKey.S:
                            this.player.Move(0, Constants.PlayerMovementSpeed);
                            break;

                        case ConsoleKey.D:
                            this.player.Move(Constants.PlayerMovementSpeed, 0);

                            break;
                    }
                }
                Thread.Sleep(20);
                Console.Clear();
            }
        }
    }
}
