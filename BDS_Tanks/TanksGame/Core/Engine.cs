using System;
using System.Collections.Generic;
using System.IO;
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
            UnitBody playerBody = new UnitBody(new List<IEnumerable<bool>> { new bool[] { false, true, false }, new bool[] { true, true, true }, new bool[] { true, true, true } }, '*', ConsoleColor.Green);

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
            Border border = new Border();
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

                //drawer.Draw(border);

                drawer.Draw(this.player);
                Thread.Sleep(Constants.ThreadSleep);
                Console.Clear();
            }
        }
    }
}
