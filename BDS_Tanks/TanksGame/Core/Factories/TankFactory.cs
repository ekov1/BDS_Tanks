﻿using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Environment;
using TanksGame.Player;

namespace TanksGame.Core.Factories
{
    public class TankFactory : ITankFactory
    {
        public ITank CreateTank(int x, int y, Texture texture)
        {
            return new Tank(x, y, texture);
        }
    }
}