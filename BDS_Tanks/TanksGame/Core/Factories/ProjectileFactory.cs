﻿using TanksGame.Contracts;
using TanksGame.Core.Contracts;
using TanksGame.Core.Enums;
using TanksGame.Projectiles;

namespace TanksGame.Core.Factories
{
    public class ProjectileFactory : IProjectileFactory
    {
        public IProjectile CreateProjectile(ProjectileType type, int x, int y, Direction direction)
        {
            switch (type)
            {
                case ProjectileType.MachineGun:
                    return new MachineGun(x, y, direction);
                case ProjectileType.Rocket:
                    return new Rocket(x, y, direction);
                    // default ?
                default:
                    return new MachineGun(x, y, direction);
            }
        }
    }
}