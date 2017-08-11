using TanksGame.Contracts;
using TanksGame.Core.Enums;

namespace TanksGame.Core.Contracts
{
    public interface IProjectileFactory
    {
        IProjectile CreateProjectile(ProjectileType type, int x, int y, Direction direction);
    }
}