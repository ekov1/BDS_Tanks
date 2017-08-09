using TanksGame.UI;
using TanksGame.UI.Contracts;

namespace TanksGame.Core.Contracts
{
    public interface ITerrain : IDrawable
    {
        bool IsPassable { get; }

        bool IsDestructable { get; }
    }
}