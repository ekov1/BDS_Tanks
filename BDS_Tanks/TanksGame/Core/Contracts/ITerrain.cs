using TanksGame.UI.Contracts;

namespace TanksGame.Core.Contracts
{
    public interface ITerrain : IDrawable, IPosition
    {
        bool IsPassable { get; }

        bool IsDestructable { get; }
    }
}