using TanksGame.Core.Enums;

namespace TanksGame.Contracts
{
    public interface IMover
    {
        void Move(IMovable obj, Direction direction);
    }
}