using TanksGame.Core.Enums;

namespace TanksGame.Contracts
{
    public interface IMover
    {
        bool Move(IMovable obj, Direction direction);
    }
}