using TanksGame.Core.Enums;
using TanksGame.UI;
using TanksGame.UI.Contracts;

namespace TanksGame.Contracts
{
    public interface ITank : IMovable, IDrawable, IShooting
    {
        ProjectileType WeaponType { get; set; }
        void Attack();
    }
}