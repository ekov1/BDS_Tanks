using TanksGame.Core.Enums;
using TanksGame.UI.Contracts;

namespace TanksGame.Contracts
{
    public interface IProjectile : IMovable, IDrawable, IPosition
    {
        Direction Direction { get; set; }

        int Damage { get; }
    }
}