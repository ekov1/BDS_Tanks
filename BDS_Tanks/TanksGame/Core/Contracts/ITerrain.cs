using TanksGame.UI;

namespace TanksGame.Core.Contracts
{
    public interface ITerrain : IDrawable
    {
        bool IsPassable { get; }

        bool IsDestructable { get; }
    }
}